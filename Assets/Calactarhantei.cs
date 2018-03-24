using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calactarhantei : MonoBehaviour
{

    public GameObject fronttobira;
    public GameObject backtobira;
    
    
    public GameObject Key;

    public static bool KeyFrag = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "ori" && KeyFrag == true)
        {
            fronttobira.GetComponent<Ori_front>().open();
            hit.gameObject.SetActive(false);
            Debug.Log("front" + hit.gameObject.name);
            print("hit");
        }

        if (hit.gameObject.tag == "ori2" && KeyFrag == true)
        {
            backtobira.GetComponent<Ori_back>().open();
            hit.gameObject.SetActive(false);
            print("hit");
        }

        if (hit.gameObject.tag == "Key")
        {

            Key.SetActive(false);
            KeyFrag = true;
        }

      
    }

}
