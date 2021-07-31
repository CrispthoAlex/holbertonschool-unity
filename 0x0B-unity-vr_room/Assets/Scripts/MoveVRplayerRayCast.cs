using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveVRplayer : MonoBehaviour
{
    // NavMeshAgent variable control player movement
    public NavMeshAgent NavPlayer;

    // A camera to follow the player movement
    public Camera playerCamera;
 
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        // If Right button is clicked
        if (Input.GetMouseButton(1))
        { 
            // Unity cast a ray from the position of mouse cursor on-screen toward the 3D scene
            Ray aRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if(Physics.Raycast(aRay, out raycastHit))
            {
                // Asign ray hit point as Destination of Navemesh Agent (Player)
                NavPlayer.SetDestination(raycastHit.point);
            }
        }
    }
}
