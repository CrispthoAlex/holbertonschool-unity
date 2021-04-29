using UnityEditor.AnimatedValues;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables for x-axis and y-axis
    // x = horizontal
    private float Horizontal;

    // z = vertical
    private float Vertical;

    // player object assignment
    public CharacterController player;

    // speed
    public float speed;

    //direction the player is moving
    public Vector3 movePlayer;

    // camera
    public Camera mainCamera;

    //camera forward
    private Vector3 camForward;

    // camera to the right
    private Vector3 camRight;

    // gravity
    private float gravity = 9.8f;

    // falling speed
    public float fallVelocity;

    // jump
    public float jumpForce;
    
    // animator
    public Animator animator;
    private static readonly int Fall = Animator.StringToHash("Fall");
    private static readonly int Runn = Animator.StringToHash("Runn");
    private static readonly int Jump = Animator.StringToHash("Jump");

    public void Start ()
    {
        player = GetComponent<CharacterController> ();

        animator = GetComponent<Animator>();
    }
    
    public void FixedUpdate()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        //camera direction
        camDirection();

        movePlayer = ((Horizontal * camRight) + (Vertical * camForward));

        movePlayer *= speed;

        player.transform.LookAt(player.transform.position + movePlayer);

        // function for gravity
        SetGravity();

        // functions
        PlayerSkills();

        if (transform.position.y > -20)
        {
            player.Move(movePlayer * Time.deltaTime);
            
        }
        
        else
        {
            //gravity = 9.8f;
            transform.position = new Vector3(0, 20, 0);
        }

        if (transform.position.y >= 20)
        {
            animator.SetBool(Fall, true);
        }
        else
        {
            animator.SetBool(Fall, false);
        }

        if (Horizontal != 0 || Vertical != 0)
        {
            animator.SetBool(Runn, true);
        }
        else
        {
            animator.SetBool(Runn, false);
        }
    }
    
    // function for the camera
    private void camDirection()
    {
        // forward direction of main camera
        var transform1 = mainCamera.transform;
        camForward = transform1.forward;
        //direction to the right of the main camera
        camRight = transform1.right;

        // y axis set to 0
        camForward.y = 0;
        // right relative to y axis set to 0
        camRight.y = 0;

        // Adjusted vector direction
        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }

    // function Skills
    private void PlayerSkills()
    {
        if (!Input.GetButtonDown("Jump") || !player.isGrounded) return;
        fallVelocity = jumpForce;
        movePlayer.y = fallVelocity;
        animator.SetTrigger(Jump);
        
    }

    // function for gravity
    private void SetGravity()
    {
        if (player.isGrounded)
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
        else
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
    }
    
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "DropTrigger")
        {
            Debug.Log(string.Format("esta en la platform"));
        }
        
    }
}
