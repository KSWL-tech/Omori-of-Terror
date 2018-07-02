using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryGameOver : MonoBehaviour {

    public  GameObject player;
    public GameObject bike;
    public GameObject player_muzzle;
    private bool flag = false;
    public float speed;
    [SerializeField] private float dist;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(flag == true)
        {
            transform.LookAt(player.transform.position);
            transform.Translate(0, 0,speed);

            Vector3 Apos = bike.transform.position;
            Vector3 Bpos = transform.position;
            float dis = Vector3.Distance(Apos, Bpos);
            // print(dis);

            if (dis < dist)
            {
                SceneController.changegameover();
            }
        }
	}

    

    public void BatteryLost()
    {
        transform.position = player_muzzle.transform.position;

        flag = true;

    }

 
}
