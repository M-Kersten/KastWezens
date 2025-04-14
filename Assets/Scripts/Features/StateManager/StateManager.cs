using System;
using UnityEngine;

public class StateManager
{
    public static StateManager Instance { get; } = new StateManager();
    
    public GameState CurrentState { get; private set; }

    public event Action<GameState> OnStateChanged;

    public StateManager(GameState initialState = GameState.DayTime)
    {
        CurrentState = initialState;
    }

    public void SetState(GameState newState)
    {
        if (CurrentState == newState) return;

        CurrentState = newState;
        Debug.Log($"Switching to state: {newState}");
        OnStateChanged?.Invoke(CurrentState);
    }

    public void ToggleState()
    {
        SetState(CurrentState == GameState.DayTime ? GameState.NightTime : GameState.DayTime);
    }
}