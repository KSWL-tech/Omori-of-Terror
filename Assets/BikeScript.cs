using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeScript : MonoBehaviour {

    private GameObject GameController;
    public static bool Controlflag = false;
    public static bool seflag = false;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    public float breakingspeed;
    private bool breaking = false;

    public GameObject breaked_enemy;
    public GameObject BikeCamera;
    public GameObject Bike_Mazzle;



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
            transform.Translate(0, 0, speed);
            transform.Rotate(0, rotation, 0);

        }

        if (breaking && speed > 0)
        {
            speed -= breakingspeed;
        }

        if (speed < 0)
        {
            Controlflag = false;
            speed = 0;
            StartCoroutine("GameOver");
        }
    }

    void Update()
    {

       /* if (seflag == true)
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

        }*/
    }

    private void breaked()
    {
        breaking = true;
        SEScript.Bike_go.Stop();

    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3);
        breaked_enemy.GetComponent<BatteryGameOver>().player = BikeCamera;
        breaked_enemy.GetComponent<BatteryGameOver>().player_muzzle = Bike_Mazzle;
        breaked_enemy.GetComponent<BatteryGameOver>().BatteryLost();

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            breaked();
        }

        if (collision.gameObject.tag == "Enemy")
        {
            SceneController.changegameover();
            print("enemy");
        }

    }
}
