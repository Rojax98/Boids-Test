using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish : MonoBehaviour {

    public Camera yokeCam;
    public float pitch;
    public float yaw;
    public float speed;
    public Vector2 StartPos;
    public Vector2 mousePos;
    public GameObject coneEat;
    public float staminaBar;
    public GameObject stamBar;

	// Use this for initialization
	void Start () {

        StartPos = yokeCam.ScreenToWorldPoint(Input.mousePosition);

        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {

        mousePos = yokeCam.ScreenToWorldPoint(Input.mousePosition);
        CharacterController();
        Eat();
        stamina();
		
	}

    void stamina()
    {

        staminaBar = coneEat.GetComponent<fishEat>().foodStore / 10;
        stamBar.transform.localScale = new Vector3(staminaBar, 1, 1);
        if(stamBar.transform.localScale.x >= 1)
        {
            stamBar.transform.localScale = new Vector3(1, 1, 1);

        }
    }

    void Eat()
    {

        if (Input.GetMouseButton(0))
        {

            var tempCol = coneEat.GetComponent<MeshRenderer>().material.color;

            tempCol.a = 1;

            coneEat.GetComponent<MeshRenderer>().material.color = tempCol;

        }
        else
        {

            var tempCol = coneEat.GetComponent<MeshRenderer>().material.color;

            tempCol.a = 0;

            coneEat.GetComponent<MeshRenderer>().material.color = tempCol;
        }

    }

    void CharacterController()
    {


        pitch += (StartPos.y - mousePos.y);
        yaw += (StartPos.x - mousePos.x) * -1;

        

        if(transform.rotation.y > 45)
        {

            transform.rotation = Quaternion.Euler(new Vector3(0, 45, 90 + pitch));

        }

        else if (transform.rotation.y < -45)
        {

            transform.rotation = Quaternion.Euler(new Vector3(0, -45, 90 + pitch));

        }

        else if (transform.rotation.z > 45)
        {

            transform.rotation = Quaternion.Euler(new Vector3(0, yaw, 90 + 45));

        }

        else if (transform.rotation.z < -45)
        {

            transform.rotation = Quaternion.Euler(new Vector3(0, yaw, 90 + -45));

        }

         else
        {

            transform.rotation = Quaternion.Euler(new Vector3(0, yaw, 90 + pitch));

        }

        if (Input.GetKey(KeyCode.W))
        {

            transform.localPosition += transform.up * Time.deltaTime * speed;

        }

        

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += transform.up * Time.deltaTime * -speed;

        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.localPosition += transform.forward * Time.deltaTime * -speed;

        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.localPosition += transform.forward * Time.deltaTime * speed;

        }
    }  
    
}
