using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object has a specific tag
        if (other.gameObject.CompareTag("Obstacle"))
        {
            // Destroy the colliding object
            Destroy(other.gameObject);
        }

    }
}
