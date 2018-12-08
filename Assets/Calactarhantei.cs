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
    public GameObject locker;
    private PartsTextScript PartsTexts;
    public GameObject Bike;
    public GameObject Wall;
    public GameObject baby;



    public GameObject Key;

    public static bool KeyFrag = false;
    

    // Use this for initialization
    void Start()
    {
        GameController = GameObject.Find("GameController");
        PartsTexts = GameObject.Find("PartsTexts").GetComponent<PartsTextScript>();
        KeyFrag = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < 250)
        {
            SceneController.changegameover();
        }
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

        if(hit.gameObject.tag == "close")
        {
            backtobira.GetComponent<Ori_back>().close();
            hit.gameObject.SetActive(false);
            baby.SetActive(true);
            baby.GetComponent<AudioSource>().Play();
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
                SEScript.Bike_go.Play();
                GameController.GetComponent<GameControllScript>().Player.SetActive(false);
                Bikecam.SetActive(true);
                BikeScript.Controlflag = true;
                BikeScript.seflag = true;
                Rigidbody rig;
                rig = Bike.GetComponent<Rigidbody>();
                rig.constraints = RigidbodyConstraints.None;
                rig.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
                Wall.SetActive(false);

                //SEScript.Bike_start.PlayOneShot(SEScript.Bike_start.clip);
            }
        }


        if (hit.gameObject.tag == "Door")
        {
            door.GetComponent<iTweenMove>().rotation();
            door.GetComponent<SphereCollider>().enabled = false;
            SEScript.irondoor.PlayOneShot(SEScript.irondoor.clip);

        }

        if (hit.gameObject.tag == "Enemy")
        {
            //SceneController.changegameover();
        }

        if (hit.gameObject.tag == "LockerDoor")
        {
            print("ロッカー");
            locker.GetComponent<iTweenMove>().rotation();
            hit.collider.isTrigger = true;
            SEScript.Door.PlayOneShot(SEScript.Door.clip);

        }

    }

}
