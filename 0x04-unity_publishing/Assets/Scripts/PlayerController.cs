using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Load Scenes
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // VARIABLES

    // ****** Public variables ******
    // Define the speed the object moves
    public float speed;
    // Used for Player health
    public int health = 5;
    // Value of the Scoretext
    public Text scoreText;
    // Value of the Health
    public Text healthText;
    // Value of the WinLose
    public Text winLoseText;
    // Call to WinLoseBG GameObject
    public Image WinLoseBG;
    // Movememnt with JoyStick
    public Joystick moveJoystick;

    // ****** Private variables ******
    // Used for Coin object
    private int score = 0;
    // Vector3 - Representation of 3D vectors and points.
    // Catch the x, y, z axis for translation and rotation movements.
    Vector3 translateObj;
    Vector3 rotateObj;
    // Reference to Rigidbody component
    Rigidbody rb;

    // METHODS AND FUNCTIONS
    // Start is called before the first frame update
    void Start()
    {
        // Use GetComponent to access the component.
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchSupported)
        {
            // Active the Touch option for device
            moveJoystick.gameObject.SetActive(true);
            // Get the value of the X and Z input axis for movement.
            translateObj.x = moveJoystick.Horizontal;// Horizontal
            translateObj.z = moveJoystick.Vertical;// Vertical
            // Invert the Axis => move in X rotate in Z
            rotateObj.x = moveJoystick.Vertical;// Vertical
            rotateObj.z = moveJoystick.Horizontal;// Horizontal
        } else
        {
            moveJoystick.gameObject.SetActive(false);
            // Get the value of the X and Z input axis for movement.
            translateObj.x = Input.GetAxis("Horizontal");
            translateObj.z = Input.GetAxis("Vertical");
            // Invert the Axis => move in X rotate in Z
            rotateObj.x = Input.GetAxis("Vertical");
            rotateObj.z = Input.GetAxis("Horizontal");
        }
        // Apply force to move the assets
        rb.AddForce(translateObj * speed * Time.deltaTime) ; 
        // Apply force to rotate the assets
        rb.transform.Rotate(rotateObj * speed * Time.deltaTime) ;
    }
    
    void Update()
    {
        // Return to menu when Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
    
    // Function to control Player game properties
    void OnTriggerEnter(Collider other)
    {
        // Used to match the Object wit the tag Pickup
        if (other.CompareTag("Pickup"))
        {
            // Increase score when touch the coin
            score++;
            // Print in Console the score
            // Debug.Log($"Score: {score}");
            // Update Score text
            SetScoreText();
            // Destroy after touch the coin.
            Destroy(other.gameObject);
        }

        // Player health is affected
        if (other.CompareTag("Trap"))
        {
            // decrement the value of health when the Player touches
            // an object tagged Trap
            health--;
            // Print in Console the health
            // Debug.Log($"Health: {health}");
            SetHealthText();
            
            if (health == 0)
            {
                // Debug.Log("Game Over!");
                winLoseText.text = "Game Over!";
                winLoseText.color = Color.white;
                WinLoseBG.color = Color.red;
                WinLoseBG.gameObject.SetActive(true);
                StartCoroutine(LoadScene(3f));
            }
        }
        // Player wins!!!
        if (other.CompareTag("Goal"))
        {
            // Debug.Log("You win!");
            winLoseText.text = "You win!";
            winLoseText.color = Color.black;
            WinLoseBG.color = Color.green;
            WinLoseBG.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3f));
        }
    }
    // Method to updated the score
    void SetScoreText()
    {
        scoreText.text = $"Score: {score}";
    }
    // Method to updated the health
    void SetHealthText()
    {
        healthText.text = $"Health: {health}";
    }
    // Method to load scene with delay
    IEnumerator LoadScene(float seconds)
    {
        // Change scene 2 seconds later
        yield return new WaitForSeconds(seconds);
        // Loads the Scene by its name or index in Build Settings
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
