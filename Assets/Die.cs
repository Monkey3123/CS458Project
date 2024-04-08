using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public Transform Cam;
    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object has a specific tag
        if (other.gameObject.CompareTag("Obstacle"))
        {
            // Destroy the colliding object
            Timer.Instance.FinalTime = Timer.Instance.TimeScore;
            SceneManager.LoadScene("GameOver");
        }

    }


    // Update is called once per frame
    void Update()
    {
        if(Cam.position.y <= -1)
        {
            Timer.Instance.FinalTime = Timer.Instance.TimeScore;
            SceneManager.LoadScene("GameOver");
        }

    }


}
