using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Define the CharacterController component
    private CharacterController controlPlayer;
    private Vector3 playerVelocity;
    private bool isGround;
    private float speed = 15.0f;
    private float jumpHeight = 1.5f;
    private float gravity = 9.81f;

    private void Start()
    {
        controlPlayer = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        // Is Player on the ground?
        isGround = controlPlayer.isGrounded;
        if (isGround && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controlPlayer.Move(move * Time.deltaTime * speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Height position is changed
        if (Input.GetButtonDown("Jump") && isGround)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -5.0f * (-gravity));
        }

        playerVelocity.y -= gravity * Time.deltaTime;
        controlPlayer.Move(playerVelocity * Time.deltaTime);
    }
}
