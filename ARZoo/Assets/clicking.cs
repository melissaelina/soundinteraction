using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicking : MonoBehaviour
{	
	//RaycastHit hit;
 	//Ray ray;
 	//public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
       /*RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) {
            Debug.Log(" you clicked on " + hit.collider.gameObject.name);

            Transform objectHit = hit.transform;
            
            // Do something with the object that was hit by the raycast.
        }*/
    }

    // Update is called once per frame
    void Update()
    {/*
           ray = Camera.main.ScreenPointToRay(Input.mousePosition);

     if(Physics.Raycast(ray, out hit))
     {
         Debug.Log(" you clicked on " + hit.collider.gameObject.name);

          if(hit.collider.gameObject.name == "Your 3D Model Name")
         {
             // Write things you want to do when you click.
         	Transform objectHit = hit.transform;
         	gameObject.GetComponent<AudioSource>().Play();
         }
     }*/
    }
}
