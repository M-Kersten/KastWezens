using UnityEngine;

public class CastleManager : MonoBehaviour
{
    public CastleView[] ActiveCastleViews;

    public CastleView GetRandomCastleView()
    {
        return ActiveCastleViews[Random.Range(0, ActiveCastleViews.Length)];
    }
}