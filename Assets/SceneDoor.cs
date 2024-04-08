using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public string scene;
    public string xz;
    // Update is called once per frame
    void Update()
    {
        if (xz == "X")
        {
            if (transform.position.x > 0.5 || transform.position.x < -0.5)
            {
                SceneManager.LoadScene(scene);
            }
        }
        else if(xz == "Z")
        {
            if (transform.position.z > 0.5 || transform.position.z < -0.5)
            {

                Timer.Instance.FinalTime = Timer.Instance.TimeScore;
                SceneManager.LoadScene(scene);
            }

        }
    }
}
