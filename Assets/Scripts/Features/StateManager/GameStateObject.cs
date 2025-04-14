using DG.Tweening;
using UnityEngine;

public class GameStateObject : MonoBehaviour
{
    [SerializeField] private GameState[] activeStates;
    [SerializeField] private bool scaleIn = false;

    void Awake()
    {
        StateManager.Instance.OnStateChanged += HandleStateChanged;
        HandleStateChanged(StateManager.Instance.CurrentState);
    }

    void OnDestroy()
    {
        StateManager.Instance.OnStateChanged -= HandleStateChanged;
    }

    void HandleStateChanged(GameState newState)
    {
        bool shouldBeActive = System.Array.Exists(activeStates, state => state == newState);
        gameObject.SetActive(shouldBeActive);

        if (scaleIn && shouldBeActive)
        {
            var originalScale = transform.localScale;
            transform.localScale = Vector3.zero;
            transform.DOScale(originalScale, 1).SetEase(Ease.InOutQuad);
        }
    }
}