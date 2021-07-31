using UnityEngine;
using UnityEngine.UI;

public class ProjectorRaycast : MonoBehaviour
{
    [SerializeField] private int rayLen = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private ProjectorController raycastedProjector;

    // Mouse Input
    [SerializeField] private KeyCode toActiveAnimation = KeyCode.Mouse1;
    // Target to Active
    [SerializeField] private Image crosshair = null;
    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveProjector";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if(Physics.Raycast(transform.position, fwd, out hit, rayLen, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    // Get the Component ProjectorController from Particle System gameObject
                    if (hit.collider.transform.gameObject.GetComponentInChildren<ProjectorController>(true))
                    {
                        raycastedProjector = hit.collider.transform.gameObject.GetComponentInChildren<ProjectorController>(true);
                    }
                    CrosshairChange(true);
                }
                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(toActiveAnimation))
                {
                    raycastedProjector.ActiveHologram();
                }
            }
        }
        else
        {
            if(isCrosshairActive)
            {
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }

    /// <summary>
    /// Method to Change the crosshair
    /// </summary>
    void CrosshairChange(bool on)
    {
        if(on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.green;
            isCrosshairActive = false;
        }
    }
}
