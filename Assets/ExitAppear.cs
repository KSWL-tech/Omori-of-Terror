using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAppear : MonoBehaviour {

    public GameObject falseRoad;
    public GameObject exitRoad;

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
            falseRoad.SetActive(false);
            exitRoad.SetActive(true);
        }
    }
}
