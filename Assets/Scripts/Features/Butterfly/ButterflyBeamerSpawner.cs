using System.Collections.Generic;
using UnityEngine;

public class ButterflyBeamerSpawner : MonoBehaviour
{
    public ButterflyConfig Config;
    public ButterflyView ButterflyPrefab;
    public CastleManager CastleManager;

    private List<ButterflyView> _activeButterflies = new();
    
    private void Awake()
    {
        StateManager.Instance.OnStateChanged += OnStateChanged;
    }

    private void OnStateChanged(GameState state)
    {
        if (state == GameState.NightTime)
            StartNightTimeRoutine();
    }

    public void SpawnNewButterfly(string filePath)
    {
        SpawnButterfly(filePath);
    }

    void StartNightTimeRoutine()
    {
        foreach (var butterfly in _activeButterflies)
            Destroy(butterfly.gameObject);
        
        _activeButterflies.Clear();
    }

    private void SpawnButterfly(string filePath)
    {
        var newButterfly = Instantiate(ButterflyPrefab, transform.position, ButterflyPrefab.transform.rotation);
        _activeButterflies.Add(newButterfly);
        newButterfly.InitializeTexture(filePath);
        newButterfly.Initialize(GameState.NightTime, Config, CastleManager);

        if (_activeButterflies.Count > Config.MaxBeamerButterflies)
        {
            var longestLivingButterfly = _activeButterflies[0];
            _activeButterflies.Remove(longestLivingButterfly);
            Destroy(longestLivingButterfly);
        }
    }
}
