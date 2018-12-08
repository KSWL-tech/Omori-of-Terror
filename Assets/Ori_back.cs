﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ori_back : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void open()
    {
        anim.SetTrigger("open");
        SEScript.irondoor.PlayOneShot(SEScript.irondoor.clip);
    }

    public void close()
    {
        anim.SetTrigger("close");
        SEScript.irondoor.PlayOneShot(SEScript.irondoor.clip);
    }
}
