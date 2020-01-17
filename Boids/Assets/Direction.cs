using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{

    public float Radius;

    public float distancetoObs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        RaycastHit hit;

        if(Physics.SphereCast(transform.position, Radius, transform.forward, out hit, 10))
        {

            distancetoObs = hit.distance;

        }

    }
}
