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
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform);
        if (!isNav) //ハマるまではルックアット
        {
            transform.Translate(0, 0, speed);
            //agent.destination = Vector3.zero;
        }
        else //ハマったらナビメッシュ発動
        {
            agent.destination = target.transform.position;
        }

        pastpos = pos;
        pos = transform.position;
        if (Vector3.Distance(pastpos, pos) < diff) isNav = true;
        else isNav = false;

    }
}
