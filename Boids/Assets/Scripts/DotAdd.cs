using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotAdd : MonoBehaviour
{

    public GameObject Host;
    bool added;

    // Start is called before the first frame update
    void Start()
    {

        Host = GameObject.FindGameObjectWithTag("Host");

    }

    // Update is called once per frame
    void Update()
    {
        
        if(added == false && Host)
        {
            Host.GetComponent<PointPlots>().dots.Add(gameObject);
            added = true;
        }


    }
}
