using System;
using JetBrains.Annotations;
using UnityEngine;

public class CastleCalibration : MonoBehaviour
{
    public CastleCalibrationView[] Castles;
    public float InputMultiplier;

    private CastleCalibrationView selectedCastleCalibration;
    private bool _isCalibrating;

    public Action<bool> OnCalibratingStateChanged;
    public Action<Vector3> OnPositionInput;
    public Action<Vector3> OnScaleInput;
    
    private void Start()
    {
        for (int i = 0; i < Castles.Length; i++)
            Castles[i].Initialize(this, i);
    }

    private void Update()
    {
        for (int i = 0; i < Castles.Length; i++)
        {
            if (Input.GetKeyDown((KeyCode)(48 + i)))
            {
                if (_isCalibrating)
                    SelectCastle(Castles[i]);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            _isCalibrating = !_isCalibrating;
            SelectCastle(null);
            OnCalibratingStateChanged?.Invoke(_isCalibrating);
        }

        float horizontal = Input.GetKey(KeyCode.RightArrow) ? 1 :
            Input.GetKey(KeyCode.LeftArrow) ? -1 : 0;

        float vertical = Input.GetKey(KeyCode.UpArrow) ? 1 :
            Input.GetKey(KeyCode.DownArrow) ? -1 : 0;

        var vectorInput = new Vector3(horizontal * InputMultiplier, vertical * InputMultiplier, 0);
        var shiftHeld = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        if (shiftHeld)
        {
            vectorInput = new Vector3(0, 0, vertical * InputMultiplier);
            OnPositionInput?.Invoke(vectorInput);
        }
        else
        {
            OnPositionInput?.Invoke(vectorInput);
        }    
    }

    void SelectCastle([CanBeNull] CastleCalibrationView castleCalibrationView)
    {
        selectedCastleCalibration = castleCalibrationView;
        foreach (var castle in Castles)
        {
            castle.SetSelected(castle == selectedCastleCalibration);
        }
    }
}
