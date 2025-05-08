using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OpenCVForUnity.Calib3dModule;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.ImgcodecsModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.UnityUtils;
using UnityEngine;
using UnityEngine.UI;

public class WebcamController : MonoBehaviour
{
    public RawImage[] displays;
    public Button CaptureTrollButton;
    public Button CaptureButterflyButton;
    public string WebcamName;
    public ArduinoManager ArduinoManager;
    
    [SerializeField] private string referenceImageName = "reference.jpg";
    [SerializeField] private OpenCVSettings settings;
    

    public Action<string, ScanType> OnCaptured;
    
    private bool _hasCapturedInitialized;
    private OpenCVProcessor _processor;
    private WebCamTexture _webcamTexture;
    private Texture2D _processedTexture;
    private Mat _webcamMat;
    private bool _isInitialized;

    void Start()
    {
        _webcamTexture = new WebCamTexture(WebcamName != string.Empty ? WebcamName : null, 1920, 1080, 60);
        foreach (var display in displays)
            display.texture = _webcamTexture;
        _webcamTexture.Play();
        
        CaptureButterflyButton.onClick.AddListener(() => Capture(ScanType.Butterfly));
        CaptureTrollButton.onClick.AddListener(() => Capture(ScanType.Troll));
        ArduinoManager.OnButtonPressed += () => Capture(ScanType.Butterfly);
        
        for (int i = 1; i < Display.displays.Length; i++)
            Display.displays[i].Activate();
        
        LoadReference();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            Capture(ScanType.Troll);
        if (Input.GetKeyDown(KeyCode.B))
            Capture(ScanType.Butterfly);
        if (Input.GetKeyDown(KeyCode.N))
            StateManager.Instance.SetState(GameState.NightTime);

        if (_isInitialized && _webcamTexture.isPlaying && _webcamTexture.didUpdateThisFrame)
            ProcessWebcamFrame();
    }
    
    void LoadReference()
    {
        _processor = new OpenCVProcessor(referenceImageName, settings);
        
        _webcamMat = new Mat(_webcamTexture.height, _webcamTexture.width, CvType.CV_8UC4);
        _processedTexture = new Texture2D(
            _webcamTexture.width, 
            _webcamTexture.height, 
            TextureFormat.RGBA32, 
            false
        );
        
        _isInitialized = true;
    }
    
    void ProcessWebcamFrame()
    {
        // Convert webcam texture to OpenCV Mat
        Utils.webCamTextureToMat(_webcamTexture, _webcamMat);
        
        // Process the image
        if (_processor.TryDetectReferenceImage(_webcamMat, out Point[] corners))
        {
            // Draw detected corners
            DrawDetectedCorners(_webcamMat, corners);
        }
        
        // Display the processed image
        Utils.matToTexture2D(_webcamMat, _processedTexture);
    }

    private void DrawDetectedCorners(Mat image, Point[] corners)
    {
        // Draw lines connecting the corners
        for (int i = 0; i < 4; i++)
        {
            Imgproc.line(
                image,
                corners[i],
                corners[(i + 1) % 4],
                new Scalar(0, 255, 0, 255),
                3
            );
        }
    }
    
    public void Capture(ScanType type, float zoomFactor = 1f)
    {
        if (!_hasCapturedInitialized)
        {
            _hasCapturedInitialized = true;
            return;
        }
        
        var w = _webcamTexture.width;
        var h = _webcamTexture.height;

        var zoomW = Mathf.RoundToInt(w / zoomFactor);
        var zoomH = Mathf.RoundToInt(h / zoomFactor);
        var startX = (w - zoomW) / 2;
        var startY = (h - zoomH) / 2;

        var croppedPixels = _webcamTexture.GetPixels(startX, startY, zoomW, zoomH);

        _processedTexture = new Texture2D(zoomW, zoomH);
        _processedTexture.SetPixels(croppedPixels);
        _processedTexture.Apply();

        var path = ImageManager.SaveTexture(_processedTexture, type);
        OnCaptured.Invoke(path, type);
    }
}
