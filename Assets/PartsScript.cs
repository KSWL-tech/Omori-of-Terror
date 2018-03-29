using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsScript : MonoBehaviour {

    public int PartsNum;//パーツの番号にinspectorで対応させる

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            SEScript.PartsSound.PlayOneShot(SEScript.PartsSound.clip);
           // Debug.Log("PartsSE");
            gameObject.SetActive(false);
            GameControllScript.pn[PartsNum] = 1;
        }
    }

    IEnumerator Sound()
    {

        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
}
