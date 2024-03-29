﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //===== Public Variables ===== //
    public float speed = 15.0f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public CharacterController controlPlayer;
    public Transform cameraRotation;

    //===== Privates Variables ===== //
    private Vector3 playerVelocity;
    private float jumpHeight = 1.5f;
    private float gravity = 9.81f;
    private Vector3 initialPosition;

    private void Start()
    {
        controlPlayer = gameObject.AddComponent<CharacterController>();
        initialPosition = transform.position;
        initialPosition.y += 20;
    }

    void Update()
    {
        // Catch the movement on x and z directions
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;


        if (move != Vector3.zero)
        {
            // Fix the direction of Player with angle between X and Z axes.
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + cameraRotation.eulerAngles.y;
            
            // Turn smooth
            float correctedAngle = Mathf.SmoothDampAngle(
                    transform.eulerAngles.y, targetAngle,
                    ref turnSmoothVelocity, turnSmoothTime);
            
            // Rotation corrected
            transform.rotation = Quaternion.Euler(0f, correctedAngle, 0f);

            // Convert rotation in a direction
            Vector3 followDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controlPlayer.Move(followDir.normalized * Time.deltaTime * speed);
        }

        // Is Player on the ground?
        if (controlPlayer.isGrounded && playerVelocity.y < 0.0f) {
            playerVelocity.y = 0.0f;
        }

        // Height position is changed
        if (Input.GetKeyDown(KeyCode.Space) && controlPlayer.isGrounded) {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -5.0f * (-gravity));
        }
        // Gravity applied
        playerVelocity.y -= gravity * Time.deltaTime;
        controlPlayer.Move(playerVelocity * Time.deltaTime);

        // Avoid Infinite Free fall, Start from beginning and time reset
        if (transform.position.y < -20.0f)
        {
            transform.position = initialPosition;
            GameObject.Find("Player").SendMessage("resetTime");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    // temporal method to Game exit
    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
