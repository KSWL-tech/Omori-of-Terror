using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtme : MonoBehaviour {
    public GameObject target;
    public GameObject parent;
    [SerializeField] private Vector3 pos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       // Vector3 temp = parent.transform.position;
       // temp += pos;

        this.transform.LookAt(target.transform.position);
        transform.Rotate( 0, 180, 0);
       // transform.position = temp;
    }
}
