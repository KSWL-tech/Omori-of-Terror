using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawn_babykun_Controll : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	Vector3 diff;
	public float diff_mag;
	UnityEngine.AI.NavMeshAgent agent;

	void Start () {
		agent=GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update (){
		diff=player.transform.position-this.transform.position;
		diff=diff.normalized;
		agent.Move(new Vector3(diff.x,0,diff.z).normalized*diff_mag);
		
	}
}
