using UnityEngine;

public class TexturedView : MonoBehaviour
{
    public Renderer[] Renderers;
    public string FilePath { get; private set; }
    private static readonly int BaseMap = Shader.PropertyToID("_BaseMap");
    
    public virtual void InitializeTexture(string filePath)
    {
        FilePath = filePath;
        var texture = ImageManager.LoadTexture(filePath);
        foreach (var renderer in Renderers)
            renderer.material.SetTexture(BaseMap, texture);
    }
}