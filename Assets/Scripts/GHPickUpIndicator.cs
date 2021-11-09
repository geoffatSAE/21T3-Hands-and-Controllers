using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHPickUpIndicator : OVRGrabbable
{
    Renderer r;

    AudioSource myAudioSource;
    public AudioClip soundFX;
    OVRHapticsClip ovrClip;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        r = GetComponent<Renderer>();
        myAudioSource = GetComponent<AudioSource>();

        //create haptic clip 
        ovrClip = new OVRHapticsClip(soundFX);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        
        
        //now do the things I want to do
        r.material.color = Color.blue;

        //add the sound play for the pickup
        myAudioSource.Play();

        
        //add the haptic to match the sound
        
        //and pass to correct controller
        if (hand.gameObject.name == "RightControllerAnchor")
        {
            OVRHaptics.RightChannel.Preempt(ovrClip);
        } else if(hand.gameObject.name == "LeftControllerAnchor")
        {
            OVRHaptics.LeftChannel.Preempt(ovrClip);
        }
               
        

    }


    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        r.material.color = Color.green;
    }
}