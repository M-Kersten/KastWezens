using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ButterflyBeamerSpawner : MonoBehaviour
{
    public ButterflyView ButterflyPrefab;
    public Transform BeamerSpawnLocation;
    public Vector4 SpawnRandomization;

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

    void StartNightTimeRoutine()
    {
        DOVirtual.DelayedCall(4, SpawnButterflies);
    }

    private void SpawnButterflies()
    {
        foreach (var butterfly in _activeButterflies)
            Destroy(butterfly.gameObject);
        
        _activeButterflies.Clear();
        
        var textureFilePaths = PlayerPrefsList.LoadStringList(Consts.ButterflyKey);
        
        for (int i = 0; i < textureFilePaths.Count; i++)
        {
            var filePath = textureFilePaths[i];
            DOVirtual.DelayedCall(i * .33f, () => SpawnButterfly(filePath));
        }
    }

    private void SpawnButterfly(string filePath)
    {
        var randomOffset = new Vector3(
            Random.Range(SpawnRandomization.x, SpawnRandomization.y), 
            Random.Range(SpawnRandomization.z, SpawnRandomization.w),
            0);
        var position = BeamerSpawnLocation.position + randomOffset;
        
        var newButterfly = Instantiate(ButterflyPrefab, position, ButterflyPrefab.transform.rotation);
        _activeButterflies.Add(newButterfly);
        var texture = ImageManager.LoadTexture(filePath);
        newButterfly.InitializeTexture(texture);
        newButterfly.Initialize(GameState.NightTime);
    }
}
