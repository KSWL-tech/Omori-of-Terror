using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick_FrontOut : MonoBehaviour {

    
    public GameObject Monster;

    public GameObject Player;

    private bool flag = false; //範囲に入ったらtrue


	// Use this for initialization
	void Start () {
        Monster.SetActive(false);//消す
	}
	
	// Update is called once per frame
	void Update () {
		if(flag == true)
        {
            //trueになったら進む
            Monster.transform.position += new Vector3(0.3f,0,0);　
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        if (flag == false)//1度だけ実行
        {
            Monster.SetActive(true);
            Monster.transform.LookAt(Player.transform);
            flag = true;
        }
    }
}
