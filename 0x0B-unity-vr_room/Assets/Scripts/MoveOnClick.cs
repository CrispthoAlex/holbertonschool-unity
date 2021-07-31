using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    private Vector3 targetPosition;
    private Camera mainCamera;
    [SerializeField] private float movementSpeed;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;    
    }

    // Update is called once per frame
    void Update()
    {
        // Get click event
        if(Input.GetMouseButtonDown(0))
        {

            // Get cursor position, clicked event
            CalculateTargetPosition();
            Debug.Log("Click event is working =>" + targetPosition);


        }
    }

    void FixedUpdate()
    {
        // Move to position
        MoveToTarget();
    }

    private void CalculateTargetPosition()
    {
        var mousePosition = Input.mousePosition;
        Vector3 transformedPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        targetPosition = new Vector3(transformedPosition.x, 1.75f, transformedPosition.z);
        Debug.Log("Calculate is working =>" + targetPosition);
    }

    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * movementSpeed);
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Debug.Log("Calculate is working =>" + Camera.main.transform.position);
    }
}
