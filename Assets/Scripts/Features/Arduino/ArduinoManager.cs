using UnityEngine;
using Uduino;

public class ArduinoManager : MonoBehaviour
{
    [SerializeField] private int ledPin = 13;
    
    private void Awake()
    {
        StateManager.Instance.OnStateChanged += OnStateChanged;
        UduinoManager.Instance.pinMode(ledPin, PinMode.Output);
    }

    private void OnStateChanged(GameState state)
    {
        var pinState = state switch
        {
            GameState.DayTime => State.LOW,
            GameState.NightTime => State.HIGH,
            _ => State.LOW
        };

        UduinoManager.Instance.digitalWrite(ledPin, pinState);
    }
}
