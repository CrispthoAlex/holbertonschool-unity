using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Load Scenes

public class CameraController : MonoBehaviour
{
    //======== Privates variables ========= //
    private Vector3 offset;

    //======== Public variables ========= //
    public Transform trackerPlayer;

    public float speed;

    private void Start()
    {
        offset = transform.position - trackerPlayer.transform.position;
        
        // Rotation on Y axis
        transform.rotation = Quaternion.Euler(
            0, trackerPlayer.transform.rotation.x, 0
            );
    }

    private void Update()
    {
        // Check mouse movement on X axis
        if (Input.GetAxis("Mouse X") != 0)
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * speed, Vector3.up) * offset;
        }
        
        transform.position = trackerPlayer.position + offset;
        
        transform.LookAt(trackerPlayer.position);

        // Avoid Infinite Free fall and Start from beginning
        if (trackerPlayer.transform.position.y < -25.0f)
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}

