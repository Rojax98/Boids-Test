using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishFood : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if(rb.useGravity == false)
        {

            rb.velocity = new Vector3(0, -3, 0);

        }

	}

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Water")
        {

            
            rb.useGravity = false;
        }

    }
}
