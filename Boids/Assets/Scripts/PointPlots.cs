
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PointPlots : MonoBehaviour
{

    public float numPoints;
    public float turnFraction;
    public float highlightOffset;
    public float highlight;
    public float nearestBoid;

    public float Radius;

    public float distancetoObs;

    public float pow;

    public GameObject dotDraw;

    public Color defaultColor;
    public Color highLightColor;
   
    public List<GameObject> dots;

    public Vector3[] Directions;

    public float[] distancetoBoid;
    public GameObject[] boids;
    public Vector3[] boidNear;

    public Vector3 bestDir;
    public Vector3 boidDir;
    public Vector3 centerOfBoids;
    Vector3 sumofBoids;

    public float disToBoid;

    // Start is called before the first frame update
    void Start()
    {
        bestDir = transform.forward;
        numPoints = 100;
        Radius = 0.0000001f;

    }

    // Update is called once per frame
    void Update()
    {


        
        
        transform.position += bestDir / 25f;
        
        

        if (dots.Count < numPoints)
        {
            //Instantiate(dotDraw);

        }


        //turnFraction += 0.000001f;

        for (int i = 0; i < numPoints; i++)
        {
            float t = i / (numPoints - 1f);
            float inclination = Mathf.Acos(1 - 2 * t);
            float azimuth = 2 * Mathf.PI * turnFraction * i;

            float x = Mathf.Sin(inclination) * Mathf.Cos(azimuth);
            float y = Mathf.Sin(inclination) * Mathf.Sin(azimuth);
            float z = Mathf.Cos(inclination);

            var colour = defaultColor;
            if ((i + highlightOffset) % highlight == 0)
            {
                colour = highLightColor;
            }

            Directions[i] = new Vector3(x, y, z);
            //dots[i].GetComponent<SpriteRenderer>().color = colour;
        }




        RaycastHit hit;




        for (int i = 0; i < Directions.Length; i++)
        {



            Vector3 DirectionB = transform.TransformDirection(Directions[i]);

            if (Physics.SphereCast(transform.position, Radius, DirectionB, out hit))
            {




                

                if (hit.distance > distancetoObs)
                {

                        distancetoObs = hit.distance;
                        bestDir = DirectionB;


                }

                else if (hit.transform.gameObject.tag == "B" && hit.transform.gameObject != gameObject)
                {


                    bestDir = DirectionB;
                    

                }

            }

          
        }

            



        









    }

}


