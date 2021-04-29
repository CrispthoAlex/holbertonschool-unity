using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // timer
    [FormerlySerializedAs("TimerText")] public Text timerText;
	private float time = 0.00f;
    private bool stop = false;

    
    // Update is called once per frame
    public void Update()
    {
        if (!stop)
        {
            time += Time.deltaTime;
            timerText.text = string.Format("{1:0}:{0:00.00}", time % 60, time / 60);
        }
    }

    public void TextWinColor()
    {
        enabled = false;
        timerText.color = Color.green;
        timerText.fontSize = 60;
    }
}
