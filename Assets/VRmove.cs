using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRmove : MonoBehaviour {


    public GameObject parent;
    public float speed;

    private float set;
	// Use this for initialization
	void Start () {
        InputTracking.disablePositionalTracking = true;

        set = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 vec = transform.position;
        vec.y = set;
        transform.position = vec;

        if (Input.GetMouseButton(0))
        {
            transform.Translate(0, 0, speed);

        }
    }
}
