using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slidedoor : MonoBehaviour
{

    Quaternion defaultRotation;
    // Start is called before the first frame update
    void Start()
    {
        defaultRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = defaultRotation;
    }
}
