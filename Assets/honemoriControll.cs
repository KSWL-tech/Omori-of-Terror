using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class honemoriControll : MonoBehaviour {
    public GameObject target;  //targetにはプレイヤーが入る。
    public float diff=0,speed;
    Vector3 pos, pastpos;
    bool isNav = false;
    UnityEngine.AI.NavMeshAgent agent;
    Quaternion def_rotation;
	// Use this for initialization
	void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = target.transform.position; //destinationには追従したいオブジェクトの座標が入る
        pos = transform.position;
        def_rotation=transform.rotation; //回転しないように。y軸周りの回転はLookAtでやってくれるので、x、z軸回転を固定に
	}
    
    // Update is called once per frame
    void Update()
    {
        //NavMeshによる自動追従は常におこない、普段はLooakatによる移動を優先して行う。どこかにハマって動けなくなったとき、前フレームと比べた時の位置が非常に近くなるため、isNavをtrueにし、NavMeshによる追従のみにすることでこれを脱する。
        transform.LookAt(target.transform);
        agent.SetDestination(target.transform.position);
        transform.rotation=def_rotation;
        /*
        if (!isNav)
        {
            //transform.Translate(0, 0, speed);
            agent.Move(transform.position-target.transform.position);
        }else {
            agent.destination=target.transform.position;
        }

        pastpos = pos;
        pos = transform.position;
        if (Vector3.Distance(pos, pastpos) < diff)
        {
            isNav = true;
        }
        else isNav = false;
        */
    }
}
