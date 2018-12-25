using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickEyes : MonoBehaviour {

    public GameObject eyes;
    public GameObject stopcol;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            eyes.SetActive(true);
            stopcol.SetActive(true);
        }
    }

    
}
