using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenMove : MonoBehaviour {

    public string move_position;
    public string rotate_position;

    public int move_value;
   // public bool isLocal;
 //   private string isLocalstr;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.V))
        {
           // rotation("y",-90);
        }
	}

    public void position()
    {
        iTween.MoveTo(gameObject, iTween.Hash(move_position, move_value,"isLocal",true));
    }

    public void rotation()
    {
        iTween.RotateTo(gameObject, iTween.Hash(rotate_position, move_value, "isLocal", true));
    }
  
}
