using System;
using UnityEngine;
using UnityEngine.UI;

public class WebcamController : MonoBehaviour
{
    public RawImage[] displays;
    public Button CaptureTrollButton;
    public Button CaptureButterflyButton;
    public string WebcamName;
    
    private WebCamTexture webcamTexture;
    private Texture2D processedTexture;

    public Action<string, ScanType> OnCaptured;

    void Start()
    {
        webcamTexture = new WebCamTexture(WebcamName != string.Empty ? WebcamName : null);
        foreach (var display in displays)
            display.texture = webcamTexture;
        webcamTexture.Play();
        CaptureButterflyButton.onClick.AddListener(() => Capture(ScanType.Butterfly));
        CaptureTrollButton.onClick.AddListener(() => Capture(ScanType.Troll));
        
        for (int i = 1; i < Display.displays.Length; i++)
            Display.displays[i].Activate();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            Capture(ScanType.Troll);
        if (Input.GetKeyDown(KeyCode.B))
            Capture(ScanType.Butterfly);
    }

    public void Capture(ScanType type)
    {
        processedTexture = new Texture2D(webcamTexture.width, webcamTexture.height);
        processedTexture.SetPixels(webcamTexture.GetPixels());
        processedTexture.Apply();
        
        var path = ImageManager.SaveTexture(processedTexture, type);
        OnCaptured.Invoke(path, type);
    }
}
