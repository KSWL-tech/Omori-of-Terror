using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_Lock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 vec = transform.position;
        vec.y = 270; 
        transform.position = vec;
	}
}
