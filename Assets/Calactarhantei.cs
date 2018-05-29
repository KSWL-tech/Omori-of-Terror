using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calactarhantei : MonoBehaviour
{

    public GameObject fronttobira;
    public GameObject backtobira;
    private GameObject GameController;
    public GameObject Bikecam;
    public GameObject door;
    private PartsTextScript PartsTexts;



    public GameObject Key;

    public static bool KeyFrag = false;
    

    // Use this for initialization
    void Start()
    {
        GameController = GameObject.Find("GameController");
        PartsTexts = GameObject.Find("PartsTexts").GetComponent<PartsTextScript>();

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
            SEScript.Key.PlayOneShot(SEScript.Key.clip);

            KeyFrag = true;
        }

        if(hit.gameObject.tag == "Bike")
        {
            PartsTexts.PrintText();
            if (GameController.GetComponent<GameControllScript>().BikeFlag == true)
            {
                Debug.Log("バイク乗れるで");
                GameController.GetComponent<GameControllScript>().Player.SetActive(false);
                Bikecam.SetActive(true);
                BikeScript.Controlflag = true;
                BikeScript.seflag = true;
                //SEScript.Bike_start.PlayOneShot(SEScript.Bike_start.clip);
            }
        }


        if (hit.gameObject.tag == "Door")
        {
            door.GetComponent<iTweenMove>().rotation();
            SEScript.irondoor.PlayOneShot(SEScript.irondoor.clip);

        }

        if (hit.gameObject.tag == "Enemy")
        {
            SceneController.changegameover();
        }

    }

}
