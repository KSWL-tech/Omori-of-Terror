using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Baby : MonoBehaviour {

    public GameObject target;
    bool isNav = false;
    NavMeshAgent agent;
    public float speed, diff;
    public Vector3 pos, pastpos;
    Quaternion def_rotation;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
       // agent.destination = target.transform.position;
       // def_rotation = transform.rotation; //回転しないように。y軸周りの回転はLookAtでやってくれるので、x、z軸回転を固定にしようと思う
    }
	
	// Update is called once per frame
	void Update () {
        if (agent.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            //navMeshAgentの操作
            Debug.Log("Navigate");
            agent.destination = target.transform.position;

        }

    }
}
