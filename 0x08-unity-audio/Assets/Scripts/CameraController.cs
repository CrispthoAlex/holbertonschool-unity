using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform cam;
    private Vector3 offset;
    private int inverted;

    public GameObject player;
    public float turnSpeed = 5.0f;

    public bool isInverted;

    // Start is called before the first frame update
    private void Start()
    {
        cam = GetComponent<Transform>();
        offset = cam.position - player.transform.position;
        if (PlayerPrefs.GetString("IsInverted") != "")
        {
            isInverted = bool.Parse(PlayerPrefs.GetString("IsInverted"));
        }
        else
        {
            isInverted = false;
        }
            
    }

    // Update is called once per frame
    public void Update()
    {
        if (isInverted)
        {
            inverted = -1;
        }
        else
        {
            inverted = 1;
        }
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * inverted * turnSpeed, Vector3.left) * offset;
        var position = player.transform.position;
        cam.position = position + offset * Time.timeScale;
        transform.LookAt(position);
    }
}