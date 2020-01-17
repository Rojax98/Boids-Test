using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishEat : MonoBehaviour {

    public float foodStore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "FishF")
        {

            foodStore += 1;
            Destroy(other.gameObject);

        }

    }
}
