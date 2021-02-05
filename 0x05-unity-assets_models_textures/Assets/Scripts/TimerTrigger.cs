using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{
    // public Timer timer;

    // It's called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Timer>().enabled = true;
        }
    }
}
