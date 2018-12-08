using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clawnbaby_controll : MonoBehaviour {
    public GameObject target;
    bool isNav = false;
    UnityEngine.AI.NavMeshAgent agent;
    public float speed, diff;
    private float navspeed;
    public Vector3 pos, pastpos;
    Quaternion def_rotation;
    private Vector3 direction;
    [SerializeField] int countlimit;
    [SerializeField] int count;
    

    public float dist;
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(target.transform.position);
        def_rotation=transform.rotation; //回転しないように。y軸周りの回転はLookAtでやってくれるので、x、z軸回転を固定にしようと思う
        navspeed = agent.speed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        agent.SetDestination(target.transform.position);
        //this.transform.LookAt(target.transform.position);
        //this.transform.rotation = Quaternion.Euler(def_rotation.x, transform.rotation.y, def_rotation.z);


        /*if(Vector3.Distance(target.transform.position, transform.position) < dist)
        {
            isNav = false;
            transform.Translate(0, 0, speed);
            print("Nav off");
        }
        else
        {
            isNav = true;
        }*/
        //未実装
        /*

        
        if (!isNav) //ハマるまでは単純にTranslate
        {
            //NavMeshAgent.Move()が相対的なベクトルを引数に取ることで、NavMeshのベイクした範囲で動くそうですが、よく分からない（とりあえず自分とFPSConとの座標を引き算して見たけど）
            //agent.Move(target.transform.position*speed - transform.position);

            
            transform.LookAt(target.transform);
           
            transform.Translate(0, 0, speed);
            agent.speed = 0;
            //direction = target.transform.position - transform.position;
            //transform.position += direction * 0.05f;
           // print("Transmode");

        }
        else //ハマったらナビメッシュ発動を発動していきたいお気持ち
        {
            //print("Navmode");
            agent.speed = navspeed;

        }

        pastpos = pos;
        pos = transform.position;
        if (Vector3.Distance(pastpos, pos) < diff && isNav == false)
        {
            count++;
            //print(diff);
        }
        else
        {
            //isNav = false;
        }

        if(count >= countlimit)
        {
            isNav = true;
            count = 0;
            StartCoroutine("Navstart");
            print("カウント超えた");
        }

         print("進んだ距離 : " + Vector3.Distance(pastpos, pos));

       // print(isNav);

    */
    }

    IEnumerator Navstart()
    {
        print("startCoroutine");
        yield return new WaitForSeconds(10);
        isNav = false;
    }
}
