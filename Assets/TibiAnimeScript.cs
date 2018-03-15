using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TibiAnimeScript : MonoBehaviour {

    private Animator anim;
    public GameObject PlayerCam;
    public static bool tibiflag = false;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(PlayerCam.transform.rotation.x);
        if (tibiflag == true)
        {
            if (PlayerCam.transform.rotation.x > 0.4)
            {
                Debug.Log("z > 0.4");
                StartCoroutine("playanim");
                
            }
        }

    }

    private IEnumerator playanim()
    {
        yield return new WaitForSeconds(1.0f);
        tibigoanim();
        tibiflag = false;
        yield return new WaitForSeconds(2.0f);
        numa.numaflag = false;
    }


    public void tibigoanim()
    {
        anim.SetTrigger("tibigomori");
    }
}
