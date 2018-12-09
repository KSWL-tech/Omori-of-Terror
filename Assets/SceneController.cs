using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public Image panel;
    public float fadespeed;

	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
           // Application.Quit();
        }
    }

    public void changemain()
    {
        StartCoroutine("Fadeout");
    }

    public void changespecial()
    {
        SceneManager.LoadScene("Cregit");
    }

    public void changetitle()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
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

    IEnumerator Fadeout()
    {
        yield return new WaitForFixedUpdate();

        panel.color += new Color(0, 0, 0, fadespeed);
        Debug.Log(panel.color.a);
        if (panel.color.a >= 1)
        {
            Debug.Log("ChangeScene");
            SceneManager.LoadScene("Nodoka");
            yield break;
        }
        StartCoroutine("Fadeout");
    }
}
