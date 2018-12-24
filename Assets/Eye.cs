using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour {

    Material mat;
    private int pattern;
    private float threshold;
    public float speed;
    private bool reflag = false;

    // Use this for initialization
    virtual protected void Start () {
        mat = GetComponent<MeshRenderer>().material;
        StartCoroutine("BlinkUp");
        pattern = (int)Random.Range(5, 20);
	}

    // Update is called once per frame
    virtual protected void Update () {
		if((int)Time.time % pattern == 0 && reflag)
        {
           // Debug.Log("Blink");
            reflag = false;
            StartCoroutine("BlinkDown");
        }
	}

    IEnumerator BlinkDown()
    {

        yield return new WaitForFixedUpdate();

        if(threshold <= 0)
        {
            StartCoroutine("BlinkUp");
            yield break;
        }

        threshold -= speed;
        mat.SetFloat("_Blink", threshold);
        StartCoroutine("BlinkDown");
    }

    IEnumerator BlinkUp()
    {

        yield return new WaitForFixedUpdate();

        if(threshold >= 0.5)
        {
           // Debug.Log("stop");
            reflag = true;
            yield break;
        }

        threshold += speed;
        mat.SetFloat("_Blink", threshold);
        StartCoroutine("BlinkUp");
    }
}
