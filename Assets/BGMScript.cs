﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//AudioSourceにアタッチしてね☆

public class BGMScript : MonoBehaviour {

    public GameObject Player;

    public GameObject Monstar;

    public float range = 20;//BGMが鳴る最大距離

    AudioSource audio;
    private bool flag = false;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {

        //距離を測る
        Vector3 Ppos = Player.transform.position;
        Vector3 Mpos = Monstar.transform.position;
        float dis = Vector3.Distance(Ppos, Mpos);
        //Debug.Log("Distance : " + dis);

        //再生・停止
        if(dis < range && flag == false)
        {
            audio.Play() ;
            flag = true;
        }
        else if(dis >= range && flag == true)
        {
            audio.Stop();
            flag = false;
        }
    }
}
