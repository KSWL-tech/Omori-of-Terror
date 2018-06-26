using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumaGimmick : MonoBehaviour {

    public GameObject anagomori;
    private bool flag = true;
    [SerializeField] private GameObject player_muzzle;
    [SerializeField] Animator anim;


    // Use this for initialization
    void Start () {
       // anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //anagomori.SetActive(true);
            if (flag)
            {
                numa.numaflag = true;
                //anagomori.transform.position = player_muzzle.transform.position;
                anim.SetTrigger("appear");
                flag = false;
            }
        }
    }

    
}
