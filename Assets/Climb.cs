using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OVRTouchSample;
using System;


public class Climb : MonoBehaviour
{
    public GameObject touch;
    public GameObject held;
    private Vector3 previousPosition;
    public Vector3 Velocity { get; private set; }

    void Start()
    {
       // rb = GetComponent(Rigidbody);
    }


    void OnTriggerEnter(Collider other)
    {
        touch = other.gameObject;
    }

    void OnTriggerExit(Collider other)
    {
        touch = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two) && touch)
        {
            GrabObject();
        }
        Velocity = (transform.position - previousPosition) / Time.deltaTime;
        previousPosition = transform.position;

        if (OVRInput.GetUp(OVRInput.Button.Two) && touch)
        {
            LetGo();
        }
    }

    void GrabObject()
    {
        //rigidbod.useGravity = false;
        held = touch;
        FixedJoint fix = gameObject.AddComponent<FixedJoint>();
        fix.breakForce = 20000;
        fix.breakTorque = 20000;
        var j = fix;
        j.connectedBody = held.GetComponent<Rigidbody>();
    }

    void LetGo()
    {
        //rigidbod.useGravity = true;
        GetComponent<FixedJoint>().connectedBody = null;
        Destroy(GetComponent<FixedJoint>());
        held.GetComponent<Rigidbody>().velocity = Velocity;
        held = null;

    }

}
