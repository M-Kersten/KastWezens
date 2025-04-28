using DG.Tweening;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class WanderBehaviour : MonoBehaviour
{
    public float wanderRadius = 10f;
    public float wanderTimer = 5f;
    [SerializeField] private Animator animator;

    private NavMeshAgent agent;
    private float timer;
    private bool _isWalking;
    private static readonly int Speed = Animator.StringToHash("Speed");

    void OnEnable()
    {
        _isWalking = false;
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;

        DOVirtual.DelayedCall(5, () =>
        {
            if (NavMesh.SamplePosition(transform.position, out NavMeshHit hit, 1.0f, NavMesh.AllAreas)) {
                agent.Warp(hit.position); // Forces the agent onto the NavMesh
            }
            _isWalking = true;
        });
    }

    void Update()
    {
        if (!_isWalking)
            return;
        
        timer += Time.deltaTime;
        animator.SetFloat(Speed, agent.velocity.magnitude);

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(Vector3.zero, wanderRadius);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    static Vector3 RandomNavSphere(Vector3 origin, float dist)
    {
        var randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;

        NavMesh.SamplePosition(randDirection, out var navHit, dist, NavMesh.AllAreas);
        return navHit.position;
    }
}