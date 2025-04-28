using UnityEngine;

[CreateAssetMenu(fileName = "ButterflyConfig", menuName = "ButterflyConfig", order = 0)]
public class ButterflyConfig : ScriptableObject
{
    [Header("Butterfly")]
    public float Speed = 10f;
    public float TurnSpeed = 50f;
    public float AvoidDistance = 5f;
    public float NoiseStrength = 0.5f;
    public float NoiseFrequency = 0.5f;
    public Vector2Int CastleSwitchInterval;

    [Header("Spawning")] 
    public int MaxBoxButterflies;
    public int MaxBeamerButterflies;
    public int MaxBoxDuration;
}