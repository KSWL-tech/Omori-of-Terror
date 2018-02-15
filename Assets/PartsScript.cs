using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsScript : MonoBehaviour {

    public int PartsNum;//パーツの番号にinspectorで対応させる

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
            gameObject.SetActive(false);
            GameControllScript.pn[PartsNum] = 1;
        }
    }
}
