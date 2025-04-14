using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ButterflySpawner : MonoBehaviour
{
    public WebcamController WebcamController;
    public ButterflyView ButterflyPrefab;
    public Transform SpawnLocation;
    public Transform PortalLocation;
    public bool Reset;

    private List<ButterflyView> _activeButterflies = new();
    
    private void Awake()
    {
        if (Reset)
            PlayerPrefsList.ClearList(Consts.ButterflyKey);

        foreach (var filePath in PlayerPrefsList.LoadStringList(Consts.ButterflyKey))
            SpawnSavedButterfly(ImageManager.LoadTexture(filePath));
        
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
            DOTween.Sequence()
                .AppendInterval(i * .5f)
                .AppendCallback(() =>
                {
                    butterfly.SetTargetOverride(PortalLocation.position);
                })
                .AppendInterval(5)
                .AppendCallback(() =>
                {
                    Destroy(butterfly.gameObject);
                });
        }
    }

    private void OnCaptured(Texture2D newTrollTexture, ScanType type)
    {
        if (type == ScanType.Butterfly)
            SpawnSavedButterfly(newTrollTexture);
    }
    
    void SpawnSavedButterfly(Texture2D newTrollTexture)
    {
        var position = SpawnLocation.position;
        var newButterfly = Instantiate(ButterflyPrefab, position, Quaternion.identity);
        _activeButterflies.Add(newButterfly);
        newButterfly.InitializeTexture(newTrollTexture);
        newButterfly.Initialize(GameState.DayTime);
    }
}