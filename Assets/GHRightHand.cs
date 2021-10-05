using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;


public class GHRightHand : OVRGrabber 
{
    


    // Start is called before the first frame update
    protected override void Start() //Override becasue not using monobehaviour now
    {
        base.Start(); //So we call the super Start or base Start in this case
    }

    // Update is called once per frame
    public override void Update() //again need to override
    {
        var hand = GetComponent<OVRHand>(); //store our hand
        checkIfPinchingObject(hand); //Im passing hand here as an argument to the method im calling (its a little cleaner)
    }
    
    public void checkIfPinchingObject(OVRHand hand)
    {
        //store whether finger is touching or not
        bool isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);        

        if (isIndexFingerPinching) //check if pinching finger and if so (if within collider range) pickup object
        {
            //is pinching., do something
            GrabBegin();


        } else //let go or we are too far away
        {
            //not pinching
            GrabEnd();
          
        }
    }

   

}
