using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsSFX : MonoBehaviour
{
    public AudioSource menuFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    
    // Play sound when button is hovered
    public void HoverFx()
    {
        menuFx.PlayOneShot(hoverFx);
    }
    // Play sound when button is clicked
    public void ClickFx()
    {
        menuFx.PlayOneShot(clickFx);
    }
}
