using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Axis rotation assigned.
    Vector3 rotationCoin = new Vector3(45, 0, 0) ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Allows Coin object rotation
        transform.Rotate(rotationCoin * Time.deltaTime);
    }
}
