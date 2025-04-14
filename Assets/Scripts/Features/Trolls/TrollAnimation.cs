using DG.Tweening;
using UnityEngine;

public class TrollAnimation : MonoBehaviour
{
    public float rotationDuration;

    private Vector3 originalScale;
    
    private void Start()
    {
        originalScale = transform.localScale;
        transform.localScale = Vector3.zero;
        transform.DOScale(originalScale, 1).SetEase(Ease.InQuad);
        
        RotateObjectContinuously();
    }

    private void OnMouseDown()
    {
        SquishyJump();
    }
    
    private void RotateObjectContinuously()
    {
        transform.DORotate(new Vector3(0, 180, 0), rotationDuration, RotateMode.FastBeyond360)
            .SetEase(Ease.InOutSine);
    }
    
    private void SquishyJump()
    {
        transform.DOPunchScale(originalScale * .7f, 1, 5);
    }
}
