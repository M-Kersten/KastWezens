using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class TrollBeamerSpawner : MonoBehaviour
{
    public BeamerTroll TrollPrefab;
    public Transform SpawnLocation;
    public Transform BeamerEnvironmentLocation;
    public Vector4 SpawnRandomization;

    private List<BeamerTroll> _activeTrolls = new();
    
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
        DOVirtual.DelayedCall(4, SpawnTrolls);
    }

    private void SpawnTrolls()
    {
        foreach (var troll in _activeTrolls)
            Destroy(troll.gameObject);
        
        _activeTrolls.Clear();
        
        var textureFilePaths = PlayerPrefsList.LoadStringList(Consts.TrollKey);
        
        for (int i = 0; i < textureFilePaths.Count; i++)
        {
            var filePath = textureFilePaths[i];
            DOVirtual.DelayedCall(i * .33f, () => SpawnTroll(filePath));
        }
    }

    private void SpawnTroll(string filePath)
    {
        Debug.Log($"spawning troll: {filePath}");
        var randomOffset = new Vector3(
            Random.Range(SpawnRandomization.x, SpawnRandomization.y), 
            Random.Range(SpawnRandomization.z, SpawnRandomization.w),
            0);
        var position = BeamerEnvironmentLocation.position + randomOffset;
        
        
        var newTroll = Instantiate(TrollPrefab, SpawnLocation.position, TrollPrefab.transform.rotation);
        newTroll.transform.DOMove(position, 1).SetEase(Ease.OutQuad);
        _activeTrolls.Add(newTroll);
        var texture = ImageManager.LoadTexture(filePath);
        newTroll.Initialize(texture);
    }
}
