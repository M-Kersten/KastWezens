using System.Linq;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class ButterflyView : TexturedView
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float turnSpeed = 50f;
    [SerializeField] private float avoidDistance = 5f;
    [SerializeField] private Transform vlinderModel;
    [SerializeField] private float noiseStrength = 0.5f;
    [SerializeField] private float noiseFrequency = 0.5f;

    public Vector3? DestinationOverride;
    
    private Airspace airspace;
    private Vector3 _targetDirection;
    private float _noiseOffset;
    private bool _isMoving;

    private void Awake()
    {
        _isMoving = false;
    }

    public void Initialize(GameState state)
    {
        var airspaces = FindObjectsByType<Airspace>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        airspace = airspaces.FirstOrDefault(item => item.State == state);
        
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

    public void SetTargetOverride(Vector3 position)
    {
        speed  *= 2;
        DestinationOverride = position;
        PickNewDirection();
    }

    void Update()
    {
        var noisyDirection = ApplyNoise(_targetDirection);
        var targetRotation = Quaternion.LookRotation(noisyDirection);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

        // Move forward
        transform.position += transform.forward * speed * Time.deltaTime;

        // Check if close to boundary
        if (!IsDirectionSafe(noisyDirection))
            PickNewDirection();

        vlinderModel.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);
    }

    bool IsDirectionSafe(Vector3 direction)
    {
        var futurePos = transform.position + direction.normalized * avoidDistance;
        var bounds = airspace.Box.bounds;

        return bounds.Contains(futurePos);
    }
    
    Vector3 ApplyNoise(Vector3 direction)
    {
        var time = Time.time * noiseFrequency + _noiseOffset;
        var perlin = new Vector3(
            Mathf.PerlinNoise(time, 0f) - 0.5f,
            Mathf.PerlinNoise(0f, time) - 0.5f,
            Mathf.PerlinNoise(time, time) - 0.5f
        );
        var noise = perlin * (2f * noiseStrength);

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
