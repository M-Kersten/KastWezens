using System;
using DG.Tweening;
using UnityEngine;
using Uduino;

public class ArduinoManager : MonoBehaviour
{
    [SerializeField] private int ledPin = 12;
    [SerializeField] private int scanButtonPin = 2;
    [SerializeField] private int nightButtonPin = 3;
    
    public Action OnButtonPressed;
    public Action OnNighButtonPressed;
    public Action<int, bool> OnDigitalRead { get; private set; }

    private UduinoDevice activeDevice;
    private int _scanButtonValue = 0;
    private int _nightButtonValue = 0;
    private bool _isCheckingInput;
    
    private void Awake()
    {
        StateManager.Instance.OnStateChanged += OnStateChanged;
        UduinoManager.Instance.pinMode(ledPin, PinMode.Output);
        UduinoManager.Instance.pinMode(scanButtonPin, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(nightButtonPin, PinMode.Input_pullup);
    }


    private void Update()
    {
        CheckButton(scanButtonPin, ref _scanButtonValue, OnButtonPressed);
        CheckButton(nightButtonPin, ref _nightButtonValue, () =>
        {
            OnNighButtonPressed?.Invoke();
            StateManager.Instance.SetState(GameState.NightTime);
        });
    }

    private void CheckButton(int buttonPin, ref int buttonValue, Action OnPress)
    {
        var newButtonValue = UduinoManager.Instance.digitalRead(buttonPin);

        if (newButtonValue != buttonValue)
        {
            Debug.Log($"button value: {newButtonValue}");
            buttonValue = newButtonValue;
    
            if (buttonValue == 1)
                OnPress?.Invoke();
        }
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
