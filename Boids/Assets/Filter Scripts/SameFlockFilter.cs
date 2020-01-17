using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Filter/Same Flock")]
public class SameFlockFilter : contextFilter
{
    public override List<Transform> filter(FlockAgent agent, List<Transform> Original)
    {
        List<Transform> filtered = new List<Transform>();
        foreach (Transform item in Original)
        {
            FlockAgent itemAgent = item.GetComponent<FlockAgent>();
            if(itemAgent != null && itemAgent.AgentFlock == agent.AgentFlock)
            {
                filtered.Add(item);
            }

        }
        return filtered;
    }
}
