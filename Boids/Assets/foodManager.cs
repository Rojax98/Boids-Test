using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodManager : MonoBehaviour {

    public float timer;
    public float foodAmount;
    public GameObject food;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += 1 * Time.deltaTime;

        if(timer >= 60) {

            Instantiate(food, new Vector3(Random.Range(-37, 37), 72, Random.Range(-31, 21) ), Quaternion.identity);
            foodAmount -= 1;
            if(foodAmount <= 0)
            {
                foodAmount = 20;
                timer = 0;
            }

        }


    }
}
