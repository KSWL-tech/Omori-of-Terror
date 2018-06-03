using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Clear : MonoBehaviour {

    public GameObject clear;
    Image panel;
    private bool clearflag = false;

	// Use this for initialization
	void Start () {
        panel = clear.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (clearflag) panel.color += new Color(0,0,0,0.02f);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bike")
        {
            clearflag = true;
        }
    }
}
