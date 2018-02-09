using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick_FrontOut : MonoBehaviour {

    
    public GameObject Monster;

    public GameObject Player;

    private bool flag = false;


	// Use this for initialization
	void Start () {
        Monster.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(flag == true)
        {
            Monster.transform.position += new Vector3(0.3f,0,0);
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        if (flag == false)
        {
            Monster.SetActive(true);
            Monster.transform.LookAt(Player.transform);
            flag = true;
        }
    }
}
