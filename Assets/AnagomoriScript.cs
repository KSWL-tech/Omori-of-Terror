using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnagomoriScript : MonoBehaviour {

    public GameObject Player;

    public float speed;
    public bool flag = false;
    public GameObject tibigomori;

    Rigidbody rid;
	// Use this for initialization
	void Start () {
        //rid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player.transform);

        if (flag == true)
        {
            //rid.AddForce(speed,0,0);
            transform.Translate(0,0,speed);
        }

        

	}

    public void tibi()
    {
        tibigomori.GetComponent<TibiAnimeScript>().tibigoanim();
    }
}
