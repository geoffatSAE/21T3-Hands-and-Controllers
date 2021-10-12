using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHPickUpIndicator : OVRGrabbable
{
    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        r = GetComponent<Renderer>();
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
    }


    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        r.material.color = Color.green;
    }
}