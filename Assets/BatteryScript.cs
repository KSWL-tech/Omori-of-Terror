using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryScript : MonoBehaviour {

    //電池につけるやつ
    public int pace;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            SEScript.PartsSound.PlayOneShot(SEScript.PartsSound.clip);
            GameControllScript.batteryn += pace;
        }
    }
}
