using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildColliderTrigger : MonoBehaviour {

    GameObject parent;

    // Use this for initialization
    void Start () {
        parent = transform.parent.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           // parent.GetComponent<Ori_front>().open();
            Debug.Log("open");
        }
    }
}
