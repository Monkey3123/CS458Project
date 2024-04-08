using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolder : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       //Invoke("drop", 2.0f);

    }


    public void drop()
    {

        rb.useGravity = true;
        Debug.Log("They see me rolling");
        InvokeRepeating("roll", 2.0f, 2.0f);

    }

    void roll()
    {

            rb.AddForce(-0.5f, 0, 0, ForceMode.Impulse);
            Debug.Log("They Hating");
 

    }

}
