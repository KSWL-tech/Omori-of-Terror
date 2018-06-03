using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick_FrontOut : MonoBehaviour {

    
    public GameObject Monster;

    public GameObject Player;

    private bool flag = false; //範囲に入ったらtrue

    [SerializeField]
    private float speed;

    Rigidbody rid;


	// Use this for initialization
	void Start () {
        Monster.SetActive(false);//消す
        rid = Monster.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(flag == true)
        {
            //trueになったら進む
            Monster.transform.Translate(0,0,speed);
            
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
