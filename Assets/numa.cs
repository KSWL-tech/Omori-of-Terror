using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Player")
        {
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed /= 2f;
        }
    }

    void OnTriggerExit(Collider hit){
        if(hit.gameObject.tag=="Player"){
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed *= 2f;
        }
    }
}
