using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllScript : MonoBehaviour {

    public GameObject Player;

    // 0 ～ 3: 残量
    // 1 ～ n: 個数
    public GameObject [] Battery;
    private int bc = 3 , bc2 = 1;
    private int bn, bn2;
    public int pace = 30;//バッテリーの持ち時間
    public static float batteryn = 119;//バッテリーの総持ち時間

    public Image[] Parts;//パーツ
    public  static int[] pn = new int [10];//パーツ取得判断　0：未取得　1：取得済み
    public Color PartsColor;

    public bool BikeFlag = false;



    // Use this for initialization
    void Start () {
       //全パーツを半透明に
        for (int i = 0; i < Parts.Length; i++)
        {
            pn[i] = 0;
           // Color c = Parts[i].color;
            //c.a = 0.5f;
            Parts[i].color = PartsColor;
        }
    }
	
	// Update is called once per frame
	void Update () {


        //説明が複雑だ

        if((int)batteryn % 10 != bc2 && (int)batteryn % 10 == 0)
        {
            Battery[bc].SetActive(false);
            bc -= 1;
            if (bc < 1) bc = 3;
            Battery[bc].SetActive(true);
            bc2 = bc;
        }
       
        bc2 = (int)batteryn % 10;

        batteryn -= 1;
        bn = (int)(batteryn / pace) + 3;
        
       // Debug.Log(bn);
        if(bn != bn2)
        {
            for (int i = 4; i < Battery.Length; i++)
            {
                if (i > bn )
                {
                    Battery[i].SetActive(false);
                }
                else
                {
                    Battery[i].SetActive(true);
                }
            }
        }
        bn2 = bn;
        batteryn += 1;


        batteryn -= Time.deltaTime;
        //Debug.Log(batteryn);

        //パーツ関連
        //明るくする
        for(int i = 0; i < Parts.Length; i++)
        {
            if(pn[i] == 1)
            {
                Parts[i].color = new Color(1, 1, 1, 1);
            }
        }

        BikeFlag = true;
        for (int i = 0; i < Parts.Length; i++)
        {
            if(pn[i] == 0)
            {
                BikeFlag = false;
            } 
        }
    }
}
