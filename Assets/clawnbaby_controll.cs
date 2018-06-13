using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clawnbaby_controll : MonoBehaviour {
    public GameObject target;
    bool isNav = false;
    UnityEngine.AI.NavMeshAgent agent;
    public float speed, diff;
    public Vector3 pos, pastpos;
    // Use this for initialization
    Quaternion def_rotation;
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(target.transform.position);
        def_rotation=transform.rotation; //回転しないように。y軸周りの回転はLookAtでやってくれるので、x、z軸回転を固定に
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform.position);
        agent.SetDestination(target.transform.position);
        /* 
        if (!isNav) //ハマるまでは単純にTranslate
        {
            //NavMeshAgent.Move()が相対的なベクトルを引数に取ることで、NavMeshのベイクした範囲で動くそうですが、よく分からない（とりあえず自分とFPSConとの座標を引き算して見たけど）
            //agent.Move(target.transform.position*speed - transform.position);
            transform.Translate(0, 0, speed);
        }
        else //ハマったらナビメッシュ発動を発動していきたいお気持ち
        {
            
        }
        transform.rotation=def_rotation;
        pastpos = pos;
        pos = transform.position;
        if (Vector3.Distance(pastpos, pos) < diff) isNav = true;
        else isNav = false;
        */
    }
}
