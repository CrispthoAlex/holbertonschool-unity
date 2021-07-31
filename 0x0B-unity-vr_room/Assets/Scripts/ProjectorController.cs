using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorController : MonoBehaviour
{
    public GameObject activeProjector;
 
    public void ActiveHologram()
    {
        if (activeProjector.activeSelf == true)
        {
            activeProjector.SetActive(false);
        }
        else
        {
            activeProjector.SetActive(true);
            activeProjector.GetComponent<ParticleSystem>().Play();
        }
    }

}
