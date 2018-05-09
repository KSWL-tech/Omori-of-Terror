using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeScript : MonoBehaviour {

    private GameObject GameController;
    public static bool Controlflag = false;
    public static bool seflag = false;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    


    // Use this for initialization
    void Start () {

        GameController = GameObject.Find("GameController");

        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Controlflag == true)
        {
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            transform.Translate(0, 0, translation);
            transform.Rotate(0, rotation, 0);

        }
    }

    void Update()
    {

        if (seflag == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                SEScript.Bike_go.Play();
                SEScript.Bike_idle.Stop();
            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                SEScript.Bike_go.Stop();
                SEScript.Bike_idle.Play();
            }

        }
    }

    void OnCollisionEnter(Collision collision)
    {

      /*  if (collision.gameObject.tag == "Player")
        {

            Debug.Log("バイク当たってるで");

            if (GameController.GetComponent<GameControllScript>().BikeFlag == true)
            {
                Debug.Log("バイク乗れるで");
                GameController.GetComponent<GameControllScript>().Player.SetActive(false);
                cam.GetComponent<Camera>().depth = 1;
                flag = true;
            }
            else
            {
                Debug.Log("バイク乗られへんで");
            }
        }*/
    }
}
