using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanganmori : MonoBehaviour {

	// Use this for initialization
	private Animator animator;
	public GameObject pointsParent;
	GameObject[] walkPoints;
	public GameObject nearestObject;//最も近いオブジェクト
	bool isTrace;
	void Start () {
		float dis=Mathf.Infinity;
		Transform[] childTransform = pointsParent.GetComponentsInChildren<Transform>();
		walkPoints=new GameObject[childTransform.Length];
		for(int i=0;i<walkPoints.Length;i++){
			walkPoints[i]=childTransform[i].gameObject;
			if( Vector3.Distance(transform.position,walkPoints[i].transform.position)<dis){
				dis=Vector3.Distance(transform.position,walkPoints[i].transform.position);
				nearestObject=walkPoints[i];
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
