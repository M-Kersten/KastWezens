using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ButterflySpawner : MonoBehaviour
{
    public WebcamController WebcamController;
    public ButterflyView ButterflyPrefab;
    public ButterflyBeamerSpawner ButterflyBeamerSpawner;
    public Transform SpawnLocation;
    public Transform TopPortalLocation;
    public Transform PortalLocation;
    public bool Reset;
    public Vector3 RandomOffsetRange;
    
    [SerializeField] private ButterflyConfig config;
    [SerializeField] private ParticleSystem _preSpawnParticles;

    private List<ButterflyView> _activeButterflies = new();
    
    private void Awake()
    {
        if (Reset)
            PlayerPrefsList.ClearList(Consts.ButterflyKey);

        foreach (var filePath in PlayerPrefsList.LoadStringList(Consts.ButterflyKey))
            SpawnSavedButterfly(filePath);
        
        WebcamController.OnCaptured += OnCaptured;
        StateManager.Instance.OnStateChanged += OnStateChanged;
    }

    private void OnStateChanged(GameState newState)
    {
        if (newState == GameState.NightTime)
           StartNightTimeRoutine();
    }

    private void StartNightTimeRoutine()
    {
        for (int i = 0; i < _activeButterflies.Count; i++)
        {
            var butterfly = _activeButterflies[i];
            FlyOut(butterfly, i * .5f);
        }
    }

    private void FlyOut(ButterflyView butterflyView, float delay = 0)
    {
        DOTween.Sequence()
            .AppendInterval(delay)
            .AppendCallback(() =>
            {
                butterflyView.SetTargetOverride(PortalLocation.position);
            });
    }

    private void OnCaptured(string newTexture, ScanType type)
    {
        if (type == ScanType.Butterfly)
            SpawnSavedButterfly(newTexture);
    }
    
    float CalculatePathLength(Vector3[] points)
    {
        float length = 0f;
        for (int i = 1; i < points.Length; i++)
            length += Vector3.Distance(points[i - 1], points[i]);
        
        return length;
    }
    
    void SpawnSavedButterfly(string filePath)
    {
        var startLocation = TopPortalLocation.position;
        var offset = 1f;
        var randomEndlocationOffset = new Vector3(
            Random.Range(-offset, offset), 
            Random.Range(-offset, offset), 
            Random.Range(-offset, offset));
        var endLocation = SpawnLocation.position + randomEndlocationOffset;
        
        var spawnParticles = Instantiate(_preSpawnParticles, startLocation, Quaternion.identity);
        var offsetStart = new Vector3(0, -.5f, 0);
        var offsetEnd = new Vector3(
            Random.Range(-RandomOffsetRange.x, RandomOffsetRange.x), 
            Random.Range(-RandomOffsetRange.y, RandomOffsetRange.y), 
            Random.Range(-RandomOffsetRange.z, RandomOffsetRange.z));
        
        var startControlPoint = startLocation + offsetStart;
        var endControlPoint = endLocation + offsetEnd;

        var path = new[]
        {
            startLocation,
            startControlPoint,
            endControlPoint,
            endLocation
        };
        
        spawnParticles.transform.DOPath(path, CalculatePathLength(path) * .5f, PathType.CatmullRom).SetEase(Ease.OutQuad).OnComplete(() =>
        {
            var newButterfly = Instantiate(ButterflyPrefab, endLocation, Quaternion.identity);
            _activeButterflies.Add(newButterfly);
            newButterfly.InitializeTexture(filePath);
            newButterfly.Initialize(GameState.DayTime, config);
            AutomaticallyFlyOut(newButterfly);
            newButterfly.OnMoveOut += ButterflyBeamerSpawner.SpawnNewButterfly;
            newButterfly.OnMoveOut += s =>
            {
                _activeButterflies.Remove(newButterfly);
            };
            Destroy(spawnParticles.gameObject);
            
            if (StateManager.Instance.CurrentState == GameState.NightTime && _activeButterflies.Count > config.MaxBoxButterflies)
                FlyOut(_activeButterflies[0]);
        });
    }

    void AutomaticallyFlyOut(ButterflyView butterflyView)
    {
        if (StateManager.Instance.CurrentState == GameState.NightTime)
            DOVirtual.DelayedCall(config.MaxBoxDuration, () => FlyOut(butterflyView));
    }
}