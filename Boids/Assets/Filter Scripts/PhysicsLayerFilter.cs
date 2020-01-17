using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Filter/Physics Layer")]
public class PhysicsLayerFilter : contextFilter
{

    public LayerMask mask;

    public override List<Transform> filter(FlockAgent agent, List<Transform> Original)
    {
        List<Transform> filtered = new List<Transform>();
        foreach (Transform item in Original)
        {
           
            if(mask == (mask | (1 << item.gameObject.layer)))
            {
                filtered.Add(item);
            }

        }
        return filtered;
    }

}
