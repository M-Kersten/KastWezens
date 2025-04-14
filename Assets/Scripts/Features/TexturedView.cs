using UnityEngine;

public class TexturedView : MonoBehaviour
{
    public Renderer[] Renderers;
    private static readonly int BaseMap = Shader.PropertyToID("_BaseMap");
    
    public virtual void InitializeTexture(Texture2D texture)
    {
        foreach (var renderer in Renderers)
            renderer.material.SetTexture(BaseMap, texture);
    }
}