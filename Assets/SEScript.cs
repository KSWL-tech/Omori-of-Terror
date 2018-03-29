using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEScript : MonoBehaviour {

    public static AudioSource PartsSound;
    public static AudioSource irondoor;


    // Use this for initialization
    void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();

        PartsSound = audioSources[0];
        irondoor = audioSources[1];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
