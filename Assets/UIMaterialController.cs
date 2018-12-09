using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMaterialController : MonoBehaviour {

    public Material mat;

	// Use this for initialization
	void Start () {
        mat.SetFloat("_isAnim", 0);
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Play()
    {
        mat.SetFloat("_isAnim", 1);
    }

    public void Stop()
    {
        mat.SetFloat("_isAnim", 0);
    }
}
