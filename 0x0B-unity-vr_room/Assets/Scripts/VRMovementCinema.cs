using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMovementCinema : MonoBehaviour
{
    public CharacterController cinemaController;
    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveLeRi = Input.GetAxis("Horizontal");
        float moveFrBk = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveLeRi + transform.forward * moveFrBk;

        cinemaController.Move(move * speed * Time.deltaTime);
    }
}
