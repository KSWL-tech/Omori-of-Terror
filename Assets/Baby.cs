using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour {

    public GameObject target;
    bool isNav = false;
    UnityEngine.AI.NavMeshAgent agent;
    public float speed, diff;
    public Vector3 pos, pastpos;
    Quaternion def_rotation;

    // Use this for initialization
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(target.transform.position);
        def_rotation = transform.rotation; //回転しないように。y軸周りの回転はLookAtでやってくれるので、x、z軸回転を固定にしようと思う
    }
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.transform.position);

    }
}
