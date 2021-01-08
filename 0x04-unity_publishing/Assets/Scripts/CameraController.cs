using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;

    void Start()
    {
        // Initial position of Camera controller
        transform.position = new Vector3(22, 26, 7);
        // Calculate and store the offset value by getting the distance
        // between the player's position and camera's position.
        offset = transform.position - player.transform.position;
        // offset(x,y,z) stored => -1, 24.8, -9
    }
    // Update is called once per frame
    void Update()
    {
        // Fixed the Camera position
        transform.position = player.transform.position + offset ;
    }
}
