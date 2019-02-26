﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodcourt_sound : MonoBehaviour
{
    public AudioClip[] aClips;
	public AudioSource myAudioSource;
	string btnName;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    	{
    		Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
    		RaycastHit Hit;
    		if (Physics.Raycast(ray, out Hit)){
    			btnName = Hit.transform.name;
    			switch(btnName)
    			{
    				case "ClassicRoundTable1":
    					myAudioSource.clip = aClips[0];
    					myAudioSource.Play();
    					break;
    				default:
    					break;

    			}
    		}
    	}
    }
}
