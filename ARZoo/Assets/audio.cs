using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FOODCOURT
public class audio : MonoBehaviour
{
    
    AudioClip audioClip;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
