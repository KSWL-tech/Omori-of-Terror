using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour {

    Material mat;
    private int pattern;
    private float threshold;
    public float speed;
    private bool reflag = false;
    public float fadespeed;
    private Color alpha;
    private Vector3 setpos;

    public static bool isStop;

    public GimmickEyes gimmick;

    // Use this for initialization
    virtual protected void Start () {
        mat = GetComponent<MeshRenderer>().material;
        StartCoroutine("BlinkUp");
        pattern = (int)Random.Range(5, 20);
        setpos = transform.position;
	}

    // Update is called once per frame
    virtual protected void Update () {
		if((int)Time.time % pattern == 0 && reflag)
        {
           // Debug.Log("Blink");
            reflag = false;
            StartCoroutine("BlinkDown");
        }

        if (isStop)
        {
            StopAllCoroutines();
            StartCoroutine("FadeOut");
        }
	}

    private void LateUpdate()
    {
        isStop = false;
    }

    private void Setup()
    {
        Color temp = mat.GetColor("_MainColor");
        temp.a = 1;
        mat.SetColor("_MainColor", temp);

        temp = mat.GetColor("_MainColor2");
        temp.a = 1;
        mat.SetColor("_MainColor2", temp);
        transform.position = setpos;

        threshold = 1;
        mat.SetFloat("_Blink", threshold);
        // StartCoroutine("BlinkUp");

        if (gimmick != null)
        {
            Debug.Log("Riset");
            gimmick.eyes.SetActive(false);
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

    IEnumerator FadeOut()
    {
        alpha = mat.GetColor("_MainColor");
        //Debug.Log(alpha);

        if (alpha.a <= 0)
        {
            Setup();
            //Debug.Log("Setup");
            yield break;
        }

        yield return new WaitForSeconds(0.02f);

        alpha.a -= fadespeed;
        mat.SetColor("_MainColor",  alpha);
        mat.SetColor("_MainColor2", mat.GetColor("_MainColor2") - new Color(0, 0, 0, fadespeed));
        threshold -= 0.05f;
        mat.SetFloat("_Blink", threshold);
        StartCoroutine("FadeOut");
    }
}
