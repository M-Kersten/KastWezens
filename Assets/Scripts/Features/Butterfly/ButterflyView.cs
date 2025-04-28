using System;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class ButterflyView : TexturedView
{
    [SerializeField] private Transform vlinderModel;
    [SerializeField] private ParticleSystem _spawnParticles;

    public Vector3? DestinationOverride;
    public Action<string> OnMoveOut;
    public Canvas CanvasDisplay;

    private ButterflyConfig _config;
    private CastleManager _castleManager;
    private CastleView _castle;
    private Airspace airspace;
    private Vector3 _targetDirection;
    private float _noiseOffset;
    private bool _isMoving;
    private float _speed;
    private Quaternion _originalCanvasRotation;

    private void Awake()
    {
        _isMoving = false;
        _originalCanvasRotation = CanvasDisplay.transform.rotation;
    }

    public void Initialize(GameState state, ButterflyConfig config, CastleManager castleManager = null)
    {
        _config = config;
        _speed = _config.Speed;
        
        if (state == GameState.DayTime)
        {
            var airspaces = FindObjectsByType<Airspace>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            airspace = airspaces.FirstOrDefault(item => item.State == state);
        }
        else if (castleManager != null)
        {
            _castleManager = castleManager;
            _castle = _castleManager.GetRandomCastleView();
            airspace = _castle.CastleAirspace;
            
            transform.position = _castle.SpawnLocation.position;
            _spawnParticles.Play();
            DelayedMoveToDifferentCastle();
        }
        
        var defaultScale = vlinderModel.transform.localScale;
        vlinderModel.transform.localScale = Vector3.zero;
        vlinderModel.transform.DOScale(defaultScale, 2).SetEase(Ease.OutQuad).OnComplete(() =>
        {
            _isMoving = true;
        });
    }

    void Start()
    {
        _noiseOffset = Random.Range(0f, 1000f);
        PickNewDirection();
    }

    void DelayedMoveToDifferentCastle()
    {
        DOVirtual.DelayedCall(Random.Range(_config.CastleSwitchInterval.x, _config.CastleSwitchInterval.y), MoveToDifferentCastle);
    }

    void MoveToDifferentCastle()
    {
        _castle = _castleManager.GetRandomCastleView();
        airspace = _castle.CastleAirspace;
        DelayedMoveToDifferentCastle();
    }

    public void SetTargetOverride(Vector3 position)
    {
        _speed = _config.Speed * 2;
        DestinationOverride = position;
        PickNewDirection();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (DestinationOverride == null)
            return;

        if (other.gameObject.CompareTag("BeamerPortal"))
        {
            OnMoveOut?.Invoke(FilePath);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        var noisyDirection = ApplyNoise(_targetDirection);
        var targetRotation = Quaternion.LookRotation(noisyDirection);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _config.TurnSpeed * Time.deltaTime);

        // Move forward
        transform.position += transform.forward * _speed * Time.deltaTime;

        // Check if close to boundary
        if (!IsDirectionSafe(noisyDirection))
            PickNewDirection();

        vlinderModel.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);

        CanvasDisplay.transform.rotation = _originalCanvasRotation;
    }

    bool IsDirectionSafe(Vector3 direction)
    {
        var futurePos = transform.position + direction.normalized * _config.AvoidDistance;
        var bounds = airspace.Box.bounds;

        return bounds.Contains(futurePos);
    }
    
    Vector3 ApplyNoise(Vector3 direction)
    {
        var time = Time.time * _config.NoiseFrequency + _noiseOffset;
        var perlin = new Vector3(
            Mathf.PerlinNoise(time, 0f) - 0.5f,
            Mathf.PerlinNoise(0f, time) - 0.5f,
            Mathf.PerlinNoise(time, time) - 0.5f
        );
        var noise = perlin * (2f * _config.NoiseStrength);

        return (direction + noise).normalized;
    }

    void PickNewDirection()
    {
        var bounds = airspace.Box.bounds;
        var center = bounds.center;
        var extents = bounds.extents;

        // Random point inside box
        var destinationPoint = DestinationOverride ?? new Vector3(
            Random.Range(center.x - extents.x, center.x + extents.x),
            Random.Range(center.y - extents.y, center.y + extents.y),
            Random.Range(center.z - extents.z, center.z + extents.z)
        );

        _targetDirection = (destinationPoint - transform.position).normalized;
    }
}
