using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraPersonVR : MonoBehaviour
{
    public Transform playerRef;
    public float mouseSensitivity = 5f;
    float xRotation = 0f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerRef.Rotate(Vector3.up * mouseX);
    }
}
