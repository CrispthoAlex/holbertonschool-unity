using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTxt : MonoBehaviour
{
    public GameObject showInfo;

    /// <summary>
    /// Method to Show the Information Box
    /// </summary>
    public void ActiveInfo()
    {
        if (!showInfo.activeSelf)
        {
            showInfo.SetActive(true);
        }
        else showInfo.SetActive(false);
    }
}
