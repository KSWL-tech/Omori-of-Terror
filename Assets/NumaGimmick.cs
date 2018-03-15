using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumaGimmick : MonoBehaviour {

    public GameObject anagomori;
    private bool flag = true;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anagomori.SetActive(true);
            if (flag)
            {
                numa.numaflag = true;
                flag = false;
            }
        }
    }

    
}
