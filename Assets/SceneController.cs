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
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void changemain()
    {
        SceneManager.LoadScene("Nodoka");
    }

    public void changespecial()
    {
        SceneManager.LoadScene("Cregit");
    }

    public void changetitle()
    {
        SceneManager.LoadScene("Title");
    }

    public static void changegameover()
    {
        SceneManager.LoadScene("Gameover");
    }

    public void quit()
    {
        Application.Quit();
    }
}
