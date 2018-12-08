using UnityEngine;



public class FPSCounter : MonoBehaviour

{

    int frameCount;
    int fps;
    float nextTime;

    // Use this for initialization
    void Start()
    {
        nextTime = Time.time + 1;
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;

        if (Time.time >= nextTime)
        {
            // 1秒経ったらFPSを表示
            Debug.Log("FPS : " + frameCount);
            fps = frameCount;
            frameCount = 0;
            nextTime += 1;
        }
    }



    private void OnGUI()

    {

        GUILayout.Label("FPS: " + fps.ToString("f2"));

    }

}
