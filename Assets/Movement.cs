using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private GameObject LeftHand;
    [SerializeField] private GameObject RightHand;
    [SerializeField] private GameObject MainCamera;
    [SerializeField] private GameObject ForwardDirection;

     private Vector3 PreviousLeft;
     private Vector3 PreviousRight;
     private Vector3 PreviousPlayer;
     private Vector3 CurrentPlayer;
     private Vector3 CurrentLeft;
     private Vector3 CurrentRight;

    //Speed
     private float Speed = 70;
     private float HandSpeed;

    void Start()
    {
        PreviousPlayer = transform.position; //set current positions
        PreviousLeft = LeftHand.transform.position; //set previous positions
        PreviousRight = RightHand.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            
            float yRotation = MainCamera.transform.eulerAngles.y;
            ForwardDirection.transform.eulerAngles = new Vector3(0, yRotation, 0);

            CurrentLeft = LeftHand.transform.position;
            CurrentRight = RightHand.transform.position;
            CurrentPlayer = transform.position;

 
            var PlayerDist = Vector3.Distance(CurrentPlayer, PreviousPlayer);
            var LeftDist = Vector3.Distance(PreviousLeft, CurrentLeft);
            var RightDist = Vector3.Distance(PreviousRight, CurrentRight);

   
            HandSpeed = ((LeftDist - PlayerDist) + (RightDist - PlayerDist));

            if (Time.timeSinceLevelLoad > 1f)
            {
                transform.position += (ForwardDirection.transform.forward * HandSpeed * Speed * Time.deltaTime) * 2;
            }

            PreviousLeft = CurrentLeft;
            PreviousRight = CurrentRight;
            PreviousPlayer = CurrentPlayer;
        }
    }
}