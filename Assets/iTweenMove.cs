using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.V))
        {
            rotation("y",-90);
        }
	}

    public void position(string str, int pos)
    {
        iTween.MoveTo(gameObject, iTween.Hash(str, pos,"isLocal",true));
    }

    public void rotation(string str,int rot)
    {
        iTween.RotateTo(gameObject, iTween.Hash(str, rot, "isLocal", true));
    }
  
}
