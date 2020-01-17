using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class FlockAgent : MonoBehaviour
{

    Flock agentFlock;
    public Flock AgentFlock { get { return agentFlock; } }

    Collider agentCol;
    public Collider agentCollider { get { return agentCol; } }

    // Start is called before the first frame update
    void Start()
    {

        agentCol = GetComponent<Collider>();

    }

    public void Initialize(Flock flock)
    {
        agentFlock = flock;

    }

    public void Move(Vector3 velocity)
    {

        transform.forward = velocity;
        transform.position += (Vector3)velocity * Time.deltaTime;

    }
}
