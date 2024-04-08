using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WinText : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text textbox;
    private float timedif;
    void Start()
    {
        if (Timer.Instance.FinalTime < Timer.Instance.RecordTime)
        {
            timedif = Timer.Instance.RecordTime - Timer.Instance.FinalTime;
            textbox.SetText("You WIN!!! \n New Record of: " + Timer.Instance.FinalTime + " Seconds \n You beat your old time of " + Timer.Instance.RecordTime + " Seconds by " + timedif + " Seconds");
            Timer.Instance.RecordTime = Timer.Instance.FinalTime;
        }
        else
        {
            textbox.SetText("You WIN!!! \n Your time was: " + Timer.Instance.FinalTime + " Seconds \n Current record: " +Timer.Instance.RecordTime + "Seconds");
        }
    }
    
  
}
