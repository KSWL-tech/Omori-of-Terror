using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeParent : Eye {

    public bool flag;
    public float nearspeed;

    // Use this for initialization
    override protected void Start () {
        base.Start();
	}

    // Update is called once per frame
    override protected void Update () {
        base.Update();

	}

    private void FixedUpdate()
    {
        if (flag)
        {
            transform.Translate(0, 0, nearspeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EyeCol")
        {
            Debug.Log("目線が合う～");
            flag = true;
        }
    }

}
