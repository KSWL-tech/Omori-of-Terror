using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEScript : MonoBehaviour {

    public static AudioSource PartsSound;
    public static AudioSource irondoor;
    public static AudioSource Key;
    public static AudioSource Bike_start;
    public static AudioSource Bike_idle;
    public static AudioSource Bike_go;
    public static AudioSource Door;





    // Use this for initialization
    void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();

        PartsSound = audioSources[0];
        irondoor = audioSources[1];
        Key = audioSources[2];
        Bike_start = audioSources[3];
        Bike_idle = audioSources[4];
        Bike_go = audioSources[5];
        Door = audioSources[6];



    }

    // Update is called once per frame
    void Update () {
		
	}
}
