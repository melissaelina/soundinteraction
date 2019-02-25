using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken_sound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
