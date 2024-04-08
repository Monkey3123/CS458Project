using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RSmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(100.0f, 0.0f, 0.0f), 8.0f); ;
    }
}
