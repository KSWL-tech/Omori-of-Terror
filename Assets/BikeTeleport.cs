using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeTeleport : MonoBehaviour {

    public Transform teleportposition; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bike")
        {
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y,teleportposition.position.z - 20);
        }
    }


}
