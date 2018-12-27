using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveRenderingSetting : MonoBehaviour {

    public int fogStartDist;
    public int fogEndDist;
    public int farClip;

    public Camera mainCam;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CaveIn()
    {
        RenderSettings.fog = false;
        mainCam.farClipPlane = farClip;
    }

    public void CaveOut()
    {
        RenderSettings.fog = true;
        mainCam.farClipPlane = 21;

    }
}
