using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTrip : MonoBehaviour
{
    public GameObject Ball;

    void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.CompareTag("Obstacle"))
            Ball.GetComponent<Bolder>().drop();


    }
  

}
