using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryGameOver : MonoBehaviour {

    public  GameObject player;
    public GameObject player_muzzle;
    private bool flag = false;
    public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(flag == true)
        {
            transform.LookAt(player.transform.position);
            transform.Translate(0, 0,speed);
        }
	}

    public void BatteryLost()
    {
        transform.position = player_muzzle.transform.position;

        flag = true;

    }
}
