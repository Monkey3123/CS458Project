using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float TimeScore, FinalTime, RecordTime;
    public static Timer Instance = null;

    void Start()
    {
        if (Instance != null)
        {
            Instance.TimeScore = 0.0f;
            Destroy(this);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        TimeScore = 0.0f;
        FinalTime = 0.0f;
        RecordTime = 9999.0f;
    }

    void Update()
    {

        TimeScore += Time.deltaTime;
        Debug.Log("Time is " + TimeScore + "FTIME IS " + FinalTime);
    }

}
