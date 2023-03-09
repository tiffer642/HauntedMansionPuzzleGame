using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    //seconds
    public float seconds = 0;
    public TextMeshProUGUI sec;
    //minutes
    public float minutes = 0;
    public TextMeshProUGUI min;
    //hours
    public float hours = 0;
    public TextMeshProUGUI hour;
    //days
    public float days = 0;
    public TextMeshProUGUI day;

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        Seconds();
        Minutes();
        Hours();
        StartTimer();
    }

    private void Seconds()
    {
        if(seconds < 60)
        {
            seconds++;
        }
        else
        {
            seconds = 0;
            minutes++;
        }
        sec.text = ":" + seconds;
    }

    private void Minutes()
    {
        if(minutes < 60)
        {
        }
        else
        {
            minutes = 0;
            hours++;
        }
        min.text = ":" + minutes;
    }

    private void Hours()
    {
        if(hours < 24)
        {
        }
        else
        {
            hours = 0;
            days++;
        }
        hour.text = ":" + hours;
        day.text = ":" + days + ":";
    }



    public void StartTimer()
    {
        StartCoroutine(Timer());
    }



}
