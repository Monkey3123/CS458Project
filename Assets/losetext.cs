using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class losetext : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text textbox;
    void Start()
    {
            textbox.SetText("You lose:( \n You lost in: " + Timer.Instance.FinalTime + " Seconds \n Current Record " + Timer.Instance.RecordTime + " Seconds");
    }


}
