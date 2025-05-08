using UnityEngine;

[CreateAssetMenu(fileName = "OpenCVSettings", menuName = "OpenCV/Processing Settings")]
public class OpenCVSettings : ScriptableObject
{
    [Header("Edge Detection")]
    [Tooltip("Lower threshold for the Canny edge detector")]
    [Range(0, 255)] public int cannyThresholdLow = 50;
    
    [Tooltip("Upper threshold for the Canny edge detector")]
    [Range(0, 255)] public int cannyThresholdHigh = 150;
    
    [Header("Feature Matching")]
    [Tooltip("Maximum distance threshold for considering a good feature match")]
    [Range(10, 200)] public int goodMatchDistanceThreshold = 50;
    
    [Tooltip("Minimum number of good matches required to consider detection successful")]
    [Range(4, 100)] public int minMatchesRequired = 10;
    
    [Header("Homography")]
    [Tooltip("Reprojection threshold used in RANSAC homography estimation")]
    [Range(1.0f, 10.0f)] public float ransacReprojectionThreshold = 5.0f;
    
    [Header("ORB Detector Settings")]
    [Tooltip("Maximum number of features to detect")]
    [Range(100, 10000)] public int maxFeatures = 500;
    
    [Tooltip("Scale factor between levels in the scale pyramid")]
    [Range(1.01f, 2.0f)] public float scaleFactor = 1.2f;
    
    [Tooltip("Number of pyramid levels")]
    [Range(1, 16)] public int pyramidLevels = 8;
}