using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ori_front : MonoBehaviour {

    Animator anim;
    Collider col;
    AudioSource audio3;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        audio3 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public  void open()
    {
        anim.SetTrigger("open");
        audio3.PlayOneShot(audio3.clip);

    }
}
