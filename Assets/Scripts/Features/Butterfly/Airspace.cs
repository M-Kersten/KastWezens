using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Airspace : MonoBehaviour
{
    [HideInInspector]
    public BoxCollider Box;

    public GameState State;

    void Awake()
    {
        Box = GetComponent<BoxCollider>();
    }
}
