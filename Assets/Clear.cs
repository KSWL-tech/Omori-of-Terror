using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Clear : MonoBehaviour {

    public GameObject clear;
    public Text text;
    public SceneController Scenecontroller;
    Image panel;
    private bool clearflag = false;
    [SerializeField] private float speed;

	// Use this for initialization
	void Start () {
        panel = clear.GetComponent<Image>();
        Scenecontroller = GameObject.Find("SceneController").GetComponent<SceneController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (clearflag)
        {
            panel.color += new Color(0, 0, 0, speed / 100);
            text.color += new Color(0, 0, 0, speed / 100);

        }
    }

    IEnumerator End()
    {

        yield return new WaitForSeconds(10);

        Scenecontroller.changetitle();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bike")
        {
            clearflag = true;
        }
    }
}
