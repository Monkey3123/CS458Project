using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Camera;
    private CapsuleCollider cap;
    void Start()
    {
        cap = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float fdist = Vector3.Dot(Camera.localPosition, Vector3.up) *1.5f;
        cap.height = Mathf.Max(cap.radius, fdist);
        cap.center = Camera.localPosition - 0.5f * fdist * Vector3.up;
    }
}
