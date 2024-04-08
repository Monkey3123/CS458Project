using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public float movespeed = 2.0f;

    private Vector3 startPoint;
    private Vector3 endPoint;
    private Vector3 currentTarget;
    public string wall;

    void Start()
    {
        startPoint = this.transform.position;
        endPoint = startPoint + new Vector3(0.0f, -1.0f, 0.0f);
        currentTarget = startPoint;
        if (wall == "no")
            InvokeRepeating("Poke", 2.0f, 1.6f);
        else if (wall == "yes")
            InvokeRepeating("Poke", Random.Range(1.0f, 3.0f), 1.6f);
    }

    void Poke()
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

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, movespeed * Time.deltaTime);

    }
}