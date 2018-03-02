using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changemain()
    {
        SceneManager.LoadScene("main");
    }

    public void changespecial()
    {
        SceneManager.LoadScene("Cregit");
    }

    public void changetitle()
    {
        SceneManager.LoadScene("Title");
    }
}
