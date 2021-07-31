using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjectMouse : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Store mOffset = gameObject world pos - OnMouseDown world pos
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        // Pixel coordinate (x, y)
        Vector3 mousePoint = Input.mousePosition;

        // Set Z coordinate of game object on screen
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        // transform.position = mousePosWorld + mOffset;
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
