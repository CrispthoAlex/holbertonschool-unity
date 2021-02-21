using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Public variables
    public Text TimerText;
    public float time = 0f;

    // Private variables
    private bool finished = false;
    private bool resetedTime = false;

    // Update is called once per frame
    void Update()
    {
        if (finished || resetedTime)
        {
            resetedTime = false;
            return;
        }
            
        time += Time.deltaTime;
        TimerText.color = Color.blue;
        TimerText.text = string.Format("{1:0}:{0:00.00}", time % 60, time / 60);
    }
    // Stop the timer when Player touch the Winflag Object
    public void Finish()
    {
        finished = true;
        TimerText.color = Color.green;
        TimerText.fontSize = 70;
    }
    // Reset the time when the player falls
    public void resetTime()
    {
        resetedTime = true;
        time = -1;
        TimerText.text = string.Format("{1:0}:{0:00.00}", time % 60, time / 60);
    }
}
