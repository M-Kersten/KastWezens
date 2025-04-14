using DG.Tweening;
using UnityEngine;

public class BeamerTroll : MonoBehaviour
{
    public MeshRenderer Renderer;
    private static readonly int BaseMap = Shader.PropertyToID("_BaseMap");

    public void Initialize(Texture2D texture)
    {
        Renderer.material.SetTexture(BaseMap, texture);
        
        var scale = transform.localScale;
        transform.localScale = Vector3.zero;
        transform.DOScale(scale, .5f).SetEase(Ease.OutQuad);
    }
}