using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMenu : MonoBehaviour
{

    SpriteRenderer sR;
    float startButtonTimer = 0.0f;

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
        if(startButton == true) //include a && for timer
        {
            
            sR.enabled = !sR.enabled;

            //to avoid multiple changes, start timer here to prevent change for ~half a second
        }

    }
}
