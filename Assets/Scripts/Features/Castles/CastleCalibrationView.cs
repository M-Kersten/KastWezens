using TMPro;
using UnityEngine;

public class CastleCalibrationView : MonoBehaviour
{
    public TextMeshProUGUI TitleLabel;
    public TextMeshProUGUI PositionLabel;
    public TextMeshProUGUI ScaleLabel;
    public CanvasGroup CanvasGroup;
    public Color ActiveColor, InActiveColor;

    private CastleCalibration _calibration;
    private bool _isSelected;
    
    public void Initialize(CastleCalibration calibration, int index)
    {
        _calibration = calibration;
        TitleLabel.SetText(index.ToString());
        _calibration.OnCalibratingStateChanged += SetCalibrating;
        SetCalibrating(false);
        UpdateLabels();
    }

    void UpdateLabels()
    {
        PositionLabel.SetText($"pos - {transform.position.x:F2}, {transform.position.y:F2}");
        ScaleLabel.SetText($"scale - {transform.localScale.x:F2}, {transform.localScale.y:F2}");
    }

    private void SetCalibrating(bool isCalibrating)
    {
        CanvasGroup.alpha = isCalibrating ? 1 : 0;
    }
    
    public void SetSelected(bool selected)
    {
        _isSelected = selected;
        TitleLabel.color = selected ? ActiveColor : InActiveColor;

        if (_isSelected)
        {
            _calibration.OnPositionInput += MoveCastle;
            _calibration.OnScaleInput += ScaleCastle;
        }
        else
        {
            _calibration.OnPositionInput -= MoveCastle;
            _calibration.OnScaleInput -= ScaleCastle;
        }
    }

    private void MoveCastle(Vector3 positionAdjust)
    {
        transform.position += positionAdjust;
        UpdateLabels();
    }

    private void ScaleCastle(Vector3 scaleAdjust)
    {
        //transform.localScale += scaleAdjust;
        UpdateLabels();
    }
}
