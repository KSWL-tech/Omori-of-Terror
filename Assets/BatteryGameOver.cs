using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryGameOver : MonoBehaviour {

    private GameObject player;
    private bool flag = false;
    public float speed;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("FirstPersonCharacter");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(flag == true)
        {
            transform.position += new Vector3(0, 0, speed);
        }
	}

    public void BatteryLost()
    {
        transform.position = player.transform.localPosition;
        transform.position += new Vector3(0, 0, 3);
        flag = true;

    }
}
