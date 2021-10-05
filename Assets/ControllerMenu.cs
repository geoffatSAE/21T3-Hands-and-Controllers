using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMenu : MonoBehaviour
{

    SpriteRenderer sR;
    float startButtonTimer = 0.0f;
    bool timerRunning;

    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        sR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        bool startButton = OVRInput.GetDown(OVRInput.Button.Start);
        if(startButton == true && timerRunning == false) //include a && for timer
        {
            
            sR.enabled = !sR.enabled;

            //to avoid multiple changes, start timer here to prevent change for ~half a second
            timerRunning = true;
        }

        if(timerRunning)
        {
            startButtonTimer += Time.deltaTime;

            if (startButtonTimer > 0.5f) //half second timer to delay between button presses
            {
                timerRunning = false;
                startButtonTimer = 0.0f;
            }
        }


    }
}
