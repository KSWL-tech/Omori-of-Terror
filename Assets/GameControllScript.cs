using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class GameControllScript : MonoBehaviour {

    public GameObject Player;
    [SerializeField]
    private float timespeed;
    [SerializeField] private int BatteryTime;

    // 0 ～ 3: 残量
    // 1 ～ n: 個数
    public GameObject [] Battery;
    private int bc = 3 , bc2 = 1;
    private int bn, bn2;
    private int batterycount;
    public int pace = 30;//バッテリーの持ち時間
    public static float batteryn = 119;//バッテリーの総持ち時間
    //public static float batteryn = 20;//バッテリーの総持ち時間


    public Image[] Parts;//パーツ
    public  static int[] pn = new int [4];//パーツ取得判断　0：未取得　1：取得済み
    public Color PartsColor;

    public bool BikeFlag = false;
    private bool batteryend = false;
    public GameObject BatteryEnemy;

    public GameObject lite;

    [SerializeField] private bool debug;


    public GameObject enemy;
    



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

        batteryn = BatteryTime;
    }
	
	// Update is called once per frame
	void Update () {

        if (BikeScript.Controlflag)
        {
            for (int i = 0; i < Battery.Length; i++)
            {
                Battery[i].SetActive(false);
            }
        }


        if (batteryend == false && BikeScript.Controlflag == false)
        {
            //説明が複雑だ
            /*

            if ((int)batteryn % 10 != bc2 && (int)batteryn % 10 == 0)
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
            if (bn != bn2)
            {
                for (int i = 4; i < Battery.Length; i++)
                {
                    if (i > bn)
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
            */


            // Battery[4 ～]の処理


            bn = (int)(batteryn / pace) + 3;
          //  print("batterynum " + batteryn);
          //  print("bn " + bn);

            for (int i = 4; i < Battery.Length; i++)
            {
                if (i > bn)
                {
                    Battery[i].SetActive(false);
                }
                else
                {
                    Battery[i].SetActive(true);
                }
            }

            //Battery[0～3]の処理
            batterycount = (int)batteryn - (pace * (bn - 3));
            //print(batterycount);
           // print("bc " + batterycount);

            for(int i = 0; i < 4; i++)
            {
                Battery[i].SetActive(false);
            }

            if (batterycount >= 0 && batterycount < 10)
            {
                Battery[0].SetActive(true);
            }
            else if(batterycount >= 10 && batterycount < 20)
            {
                Battery[1].SetActive(true);
            }
            else if(batterycount >= 20 && batterycount < 30)
            {
                Battery[2].SetActive(true);
            }
            else
            {
                Battery[3].SetActive(true);
            }


            batteryn -= Time.deltaTime * timespeed;

        }

        //バッテリー切れ処理
        if(batteryn < 2 && batteryend  == false)
        {
            Debug.Log("バッテリーなくなった");
            //BatteryEnemy.GetComponent<BatteryGameOver>().BatteryLost();
            StartCoroutine("Over");
            lite.SetActive(false);
            for (int i = 0; i < Battery.Length; i++)
            {
                    Battery[i].SetActive(false);                         
            }
            enemy.SetActive(false);
            batteryend = true;
        }



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
                if (debug == false)
                {
                    BikeFlag = false;
                }
            } 
        }



    }

    IEnumerator Over()
    {
        yield return new WaitForSeconds(10);
        BatteryEnemy.GetComponent<BatteryGameOver>().BatteryLost();
    }
}
