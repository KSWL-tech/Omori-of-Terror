using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartsTextScript : MonoBehaviour {

    
    public Text []partstexts;
    public bool flag = true;
    Animator anim;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void PrintText()
    {
        if (flag)
        {
            anim.SetTrigger("On");
            flag = false;
        }
        for(int i = 0; i < GameControllScript.pn.Length; i++)
        {
            //partstexts[i].color = new Color(255,255,255,255);
            if (GameControllScript.pn[i] == 1)
            {
                partstexts[i].text = "取り換え完了";
            }
        }

        StartCoroutine("FadeText");
    }

    IEnumerator FadeText()
    {
        yield return new WaitForSeconds(5);
        flag = true;
       // anim.SetTrigger("Fade");
        
    }
}
