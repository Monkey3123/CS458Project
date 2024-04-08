using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FloatingPlatform : MonoBehaviour
{
    public float movespeed = 2.0f;

    private Vector3 startPoint;
    private Vector3 endPoint;
    private Vector3 currentTarget;

    private void Start()
    {
        startPoint = this.transform.position;
        endPoint = startPoint + new Vector3(0.0f, 2.2f, 0.0f);
        currentTarget = startPoint;
        InvokeRepeating("move", Random.Range(1.0f, 12.0f), 5.0f);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, movespeed * Time.deltaTime);


    }

    void move()
    {
        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            if (currentTarget == startPoint)
            {
                currentTarget = endPoint;
            }
            else
            {
                currentTarget = startPoint;
            }
        }

    }
}