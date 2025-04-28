using DG.Tweening;
using UnityEngine;

public class Troll : TexturedView
{
    public Vector2 HorizontalEndPosition;
    public Vector2 DepthEndPosition;
    
    public override void InitializeTexture(string filePath)
    {
        base.InitializeTexture(filePath);
        
        var endPosition = new Vector3(Random.Range(HorizontalEndPosition.x, HorizontalEndPosition.y), 0,
            Random.Range(DepthEndPosition.x, DepthEndPosition.y));
        transform.DOMove(endPosition, 1)
            .SetDelay(.5f)
            .SetEase(Ease.InOutSine);
    }
}