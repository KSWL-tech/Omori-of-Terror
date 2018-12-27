using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGimmick : MonoBehaviour {

    public GameObject beforeRoad;
    public GameObject afterRoad;
    public CaveRenderingSetting CaveRenderingSetting;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            beforeRoad.SetActive(false);
            afterRoad.SetActive(true);
            CaveRenderingSetting.CaveOut();
        }
    }
}
