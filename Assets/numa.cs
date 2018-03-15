using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numa : MonoBehaviour {

    public GameObject anagomori;
    public GameObject tibigomori;
    private float speed;
    public static bool numaflag = false;

    // Use this for initialization
    void Start () {
		speed = UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed / 2f;
    }
	
	// Update is called once per frame
	void Update () {
        if (numaflag)
        {
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed;
        }
        else
        {
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed * 2;
        }
    }

    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Player")
        {
          //  UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed;
        }
    }

    void OnTriggerExit(Collider hit){
        if(hit.gameObject.tag=="Player"){
          //  UnityStandardAssets.Characters.FirstPerson.FirstPersonController.bufSpeed = speed * 2;
            anagomori.SetActive(false);
            tibigomori.SetActive(true);

            TibiAnimeScript.tibiflag = true;
        }
    }
}
