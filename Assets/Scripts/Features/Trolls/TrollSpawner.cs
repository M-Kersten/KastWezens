using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TrollSpawner : MonoBehaviour
{
    public WebcamController WebcamController;
    public Troll TrollPrefab;
    public Transform SpawnLocation;
    public Transform PortalLocation;
    public Button NightTimeButton;
    public bool ResetTrolls;
    public ParticleSystem SpawnParticles;

    private List<Troll> _activeTrolls = new();
    
    private void Awake()
    {
        if (ResetTrolls)
            PlayerPrefsList.ClearList(Consts.TrollKey);

        foreach (var filePath in PlayerPrefsList.LoadStringList(Consts.TrollKey))
            SpawnSavedTroll(ImageManager.LoadTexture(filePath));
        
        NightTimeButton.onClick.AddListener(NightTimeRoutine);
        WebcamController.OnCaptured += OnCaptured;
    }

    void NightTimeRoutine()
    {
        for (int i = 0; i < _activeTrolls.Count; i++)
        {
            var troll = _activeTrolls[i];
            troll.transform.DOMove(PortalLocation.position, 2)
                .SetEase(Ease.OutQuad)
                .SetDelay(i * .5f + 2);
            troll.transform.DOScale(Vector3.zero, 1)
                .SetEase(Ease.OutQuad)
                .SetDelay(i * .5f + 2.5f)
                .OnComplete(() =>
                {
                    Destroy(troll.gameObject);
                });
        }
        _activeTrolls.Clear();
    }

    private void OnCaptured(Texture2D newTrollTexture, ScanType type)
    {
        if (type == ScanType.Troll)
            SpawnSavedTroll(newTrollTexture);
    }

    void SpawnSavedTroll(Texture2D newTrollTexture)
    {
        SpawnParticles.Play();
        var position = SpawnLocation.position;
        var newTroll = Instantiate(TrollPrefab, position, Quaternion.identity);
        newTroll.transform.eulerAngles = new Vector3(0, 180, 0);
        _activeTrolls.Add(newTroll);
        newTroll.InitializeTexture(newTrollTexture);
    }
}
