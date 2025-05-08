using System.Collections.Generic;
using System.IO;
using System.Linq;
using OpenCVForUnity.Calib3dModule;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.ImgcodecsModule;
using OpenCVForUnity.ImgprocModule;
using UnityEngine;

public class OpenCVProcessor
{
    // Default settings used if no scriptable object is provided
    private static readonly OpenCVSettings DefaultSettings = ScriptableObject.CreateInstance<OpenCVSettings>();

    private ORB _featureDetector;
    private Mat _referenceImage;
    private MatOfKeyPoint _referenceKeypoints;
    private Mat _referenceDescriptors;
    private BFMatcher _matcher;
    private OpenCVSettings _settings;

    public OpenCVProcessor(string referenceImageName) : this(referenceImageName, DefaultSettings)
    {
    }

    public OpenCVProcessor(string referenceImageName, OpenCVSettings settings)
    {
        _settings = settings ?? DefaultSettings;
        
        // Configure ORB detector with settings
        _featureDetector = ORB.create(
            _settings.maxFeatures,
            _settings.scaleFactor,
            _settings.pyramidLevels
        );
        
        _matcher = new BFMatcher(DescriptorMatcher.BRUTEFORCE_HAMMING, true);
        
        LoadReferenceImage(referenceImageName);
    }

    private void LoadReferenceImage(string referenceImageName)
    {
        string path = Path.Combine(Application.streamingAssetsPath, referenceImageName);
        _referenceImage = Imgcodecs.imread(path, Imgcodecs.IMREAD_GRAYSCALE);
        
        // Apply edge detection to the reference image
        Imgproc.Canny(_referenceImage, _referenceImage, _settings.cannyThresholdLow, _settings.cannyThresholdHigh);

        // Detect features in the reference image
        _referenceKeypoints = new MatOfKeyPoint();
        _referenceDescriptors = new Mat();
        _featureDetector.detectAndCompute(_referenceImage, new Mat(), _referenceKeypoints, _referenceDescriptors);
    }

    public bool TryDetectReferenceImage(Mat webcamImage, out Point[] detectedCorners)
    {
        detectedCorners = null;
        
        // Convert and process the camera image
        Mat grayscaleImage = new Mat();
        Imgproc.cvtColor(webcamImage, grayscaleImage, Imgproc.COLOR_RGBA2GRAY);
        Imgproc.Canny(grayscaleImage, grayscaleImage, _settings.cannyThresholdLow, _settings.cannyThresholdHigh);

        // Extract features from the camera image
        var cameraKeypoints = new MatOfKeyPoint();
        var cameraDescriptors = new Mat();
        _featureDetector.detectAndCompute(grayscaleImage, new Mat(), cameraKeypoints, cameraDescriptors);

        // Validate descriptors
        if (cameraDescriptors.empty() || _referenceDescriptors.empty())
        {
            grayscaleImage.release();
            return false;
        }

        // Match features between reference and camera images
        if (!TryMatchFeatures(cameraKeypoints, cameraDescriptors, out detectedCorners))
        {
            grayscaleImage.release();
            return false;
        }

        grayscaleImage.release();
        return true;
    }

    private bool TryMatchFeatures(MatOfKeyPoint cameraKeypoints, Mat cameraDescriptors, out Point[] detectedCorners)
    {
        detectedCorners = null;
        
        // Match descriptors
        MatOfDMatch matches = new MatOfDMatch();
        _matcher.match(_referenceDescriptors, cameraDescriptors, matches);

        // Filter good matches by distance threshold
        List<DMatch> goodMatches = matches.toList()
            .Where(match => match.distance < _settings.goodMatchDistanceThreshold)
            .ToList();
            
        matches.release();

        // Ensure we have enough good matches
        if (goodMatches.Count < _settings.minMatchesRequired)
            return false;

        // Extract matched points
        var referencePoints = ExtractMatchedPoints(_referenceKeypoints, goodMatches, true);
        var cameraPoints = ExtractMatchedPoints(cameraKeypoints, goodMatches, false);

        // Find homography between the two sets of points
        Mat homography = Calib3d.findHomography(
            referencePoints, 
            cameraPoints, 
            Calib3d.RANSAC, 
            _settings.ransacReprojectionThreshold
        );
        
        referencePoints.release();
        cameraPoints.release();

        if (homography.empty())
        {
            homography.release();
            return false;
        }

        // Transform reference corners to camera image
        detectedCorners = TransformReferenceCorners(homography);
        homography.release();
        
        return true;
    }

    private MatOfPoint2f ExtractMatchedPoints(MatOfKeyPoint keypoints, List<DMatch> matches, bool isQuery)
    {
        List<Point> points = new List<Point>();
        var keypointsList = keypoints.toList();

        foreach (var match in matches)
        {
            int idx = isQuery ? match.queryIdx : match.trainIdx;
            points.Add(keypointsList[idx].pt);
        }

        return new MatOfPoint2f(points.ToArray());
    }

    private Point[] TransformReferenceCorners(Mat homography)
    {
        // Define corners of the reference image
        Point[] referenceCorners = {
            new(0, 0),
            new(_referenceImage.cols(), 0),
            new(_referenceImage.cols(), _referenceImage.rows()),
            new(0, _referenceImage.rows())
        };

        MatOfPoint2f referenceCornersMat = new MatOfPoint2f(referenceCorners);
        MatOfPoint2f cameraCornersMat = new MatOfPoint2f();

        // Transform reference corners to camera image
        Core.perspectiveTransform(referenceCornersMat, cameraCornersMat, homography);
        
        Point[] result = cameraCornersMat.toArray();
        
        referenceCornersMat.release();
        cameraCornersMat.release();
        
        return result;
    }
}