using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleRotate : MonoBehaviour {


    public float limit;
   // public float speed;


    public float maxAngle = 60; // 最大回転角度
    public float minAngle = -60; // 最小回転角度
    public float speed = 0.5f; // 回転スピード(お好みで調整してください)
    public GameObject bike;
    void Start()
    {
    }

    void Update()
    {
        // 入力情報
        float turn = Input.GetAxis("Horizontal");
        // 現在の回転角度を0～360から-180～180に変換
        float rotateY = (transform.eulerAngles.y > 180) ? transform.eulerAngles.y - 360 : transform.eulerAngles.y;
        // 現在の回転角度に入力(turn)を加味した回転角度をMathf.Clamp()を使いminAngleからMaxAngle内に収まるようにする
        float angleY = Mathf.Clamp(rotateY + turn * speed, minAngle, maxAngle);
        // 回転角度を-180～180から0～360に変換
        angleY = (angleY < 0) ? angleY + 360 : angleY;
        // 回転角度をオブジェクトに適用
        transform.rotation = Quaternion.Euler(0, angleY, 0);

        transform.position = bike.transform.position;
    }

/*
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(BikeScript.Controlflag == true)
        {
            if (Input.GetKey(KeyCode.A) && transform.rotation.y > -limit)
            {
                transform.Rotate(0, -speed, 0);
            }else if(Input.GetKey(KeyCode.D) && transform.rotation.y < limit)
            {
                transform.Rotate(0, speed, 0);
            }
            
            if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                if(transform.rotation.y > 1)
                {
                    transform.Rotate(0, -speed, 0);
                }
                else if(transform.rotation.y < -1)
                {
                    transform.Rotate(0, speed, 0);
                }
            }
        }
	}*/
}
