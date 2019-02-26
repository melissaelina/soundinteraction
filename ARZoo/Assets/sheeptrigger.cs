using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheeptrigger : MonoBehaviour
{   
    AudioClip audioClip;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<AudioSource>().Play();
       // audioClip = Resources.Load("sheep_info") as AudioClip;
        //audioSource = gameObject.AddComponent<AudioSource>();
    }
   
    private void OnCollisionEnter(Collision collision)
        {
    //float audioLevel = collision.relativeVelocity.magnitude / 10.0f;
    //audioSource.PlayOneShot(audioClip);
    gameObject.GetComponent<AudioSource>().Play();
        }

    void OnCollisionEnter ()  //Plays Sound Whenever collision detected
     {
         //gameObject.GetComponent<AudioSource>().Play();
         //GetComponent<AudioSource> ().Play ();
     }
   
    // Update is called once per frame
    void Update()
    {
      /*   //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
       //  {

        
        //if(Input.GetMouseButtonDown(0))
         //{gameObject.GetComponent<AudioSource>().Play();}
        //}


                RaycastHit hit = new RaycastHit();
        for (int i = 0; i < Input.touchCount; ++i) {
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
            // Construct a ray from the current touch coordinates
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
            if (Physics.Raycast(ray, out hit)) {
                hit.transform.gameObject.SendMessage("OnMouseDown");
                                                }
                                                                }
                                                }
    


      Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit rayhit = new RaycastHit();
        if (Physics.Raycast(ray, out rayhit)){ gameObject.GetComponent<AudioSource>().Play();}


*/
    }

}
/*

 using UnityEngine;
 using System.Collections;
 
  //Add this Script Directly to The Death Zone
 public class sheeptrigger : MonoBehaviour
 {
     public AudioClip sheep_info;    // Add your Audi Clip Here;
     // This Will Configure the  AudioSource Component; 
     // MAke Sure You added AudioSouce to death Zone;
     void Start ()   
     {
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = sheep_info;
     }        
 
     void OnCollisionEnter ()  //Plays Sound Whenever collision detected
     {
         GetComponent<AudioSource> ().Play ();
     }
          // Make sure that deathzone has a collider, box, or mesh.. ect..,
          // Make sure to turn "off" collider trigger for your deathzone Area;
          // Make sure That anything that collides into deathzone, is rigidbody;
 }
*/