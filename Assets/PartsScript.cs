using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsScript : MonoBehaviour {

    public int PartsNum;//パーツの番号にinspectorで対応させる
    private AudioSource PartsSE;

	// Use this for initialization
	void Start () {
        PartsSE = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {
            sound();
        }
    }

    private void sound()
    {
        PartsSE.PlayOneShot(PartsSE.clip);

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            //PartsSE.PlayOneShot(PartsSE.clip);
            // sound();
            StartCoroutine(Sound());
            Debug.Log("PartsSE");
            GameControllScript.pn[PartsNum] = 1;
        }
    }

    IEnumerator Sound()
    {

        PartsSE.PlayOneShot(PartsSE.clip);
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
}
