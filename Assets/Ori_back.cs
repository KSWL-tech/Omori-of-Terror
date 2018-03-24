using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ori_back : MonoBehaviour {

    Animator anim;
    AudioSource audio2;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        audio2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void open()
    {
        anim.SetTrigger("open");
        audio2.PlayOneShot(audio2.clip);
    }
}
