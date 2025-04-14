using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class GameStateButton : MonoBehaviour
{
    [SerializeField] private GameState gameState;
    
    private Button _button;

    void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeToNightTime);
    }

    private void ChangeToNightTime()
    {
        StateManager.Instance.SetState(gameState);
    }
}