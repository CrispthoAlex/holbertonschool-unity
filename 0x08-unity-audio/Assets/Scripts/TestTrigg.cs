using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigg : MonoBehaviour
{
    // player object assignment
    public CharacterController player;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("otrotaggg"))
        {
            Debug.Log("You win!");
        }
    }
}
