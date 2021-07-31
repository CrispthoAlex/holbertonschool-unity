using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorController : MonoBehaviour
{
    private Animator doorAnima;

    //private bool doorOpen = false;

    private void Awake()
    {
        doorAnima = transform.parent.gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if(doorAnima.GetBool("character_nearby"))
        {
            doorAnima.SetBool("character_nearby", false);
        }
        else
        {
            doorAnima.SetBool("character_nearby", true);
        }
    }

}
