using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScene : MonoBehaviour {

    SceneController SceneController; 

	// Use this for initialization
	void Start () {
        SceneController = GetComponent<SceneController>();

        StartCoroutine("Change");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Change()
    {
        yield return new WaitForSeconds(6);

        SceneController.changetitle();
    }
}
