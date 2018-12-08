using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class numa : MonoBehaviour {

    public GameObject anagomori;
    public GameObject tibigomori;
    private float speed;
    public static bool numaflag = false;
    public GameObject mainenemy;

    // Use this for initialization
    void Start () {
		speed = UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed / 2f;
        mainenemy.GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (numaflag)
        {
          //  UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed;
           // UnityStandardAssets.Characters.FirstPerson.FirstPersonController.numasound = true;
        }
        else
        {
          //  UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed * 2;
          //  UnityStandardAssets.Characters.FirstPerson.FirstPersonController.numasound = false;

        }
    }

    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Player")
        {
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed;
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.numasound = true;
            mainenemy.GetComponent<NavMeshAgent>().speed = 0;
        }
    }

    void OnTriggerExit(Collider hit){
        if(hit.gameObject.tag=="Player"){
             UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed * 2;
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.numasound = false;

            anagomori.SetActive(false);
            // tibigomori.SetActive(true);
            mainenemy.GetComponent<NavMeshAgent>().speed = 5;
            TibiAnimeScript.tibiflag = true;
        }
    }
}
