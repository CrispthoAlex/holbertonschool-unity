using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // VARIABLES
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;
    
    // trapMat = GetComponent<Material> ();
    // goalMat = GetComponent<Material> ();
    // colorblindMode = GetComponent<Toggle> ();
    
    //  load the maze scene when the Play button is pressed
    public void PlayMaze()
    {
        if (colorblindMode.isOn)
        {
            // Constructs a new Color32 with given r, g, b, a components.
            trapMat.color = new Color32(255, 112, 0, 1);
            // Change Goal area to blue color
            goalMat.color = Color.blue;
        }
        else
        {
            // Constructs a new Color32 with given r, g, b, a components.
            trapMat.color = Color.red;
            // Change Goal area to blue color
            goalMat.color = Color.green;
        }
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    // Exit game when Quit button is pressed
    public void QuitMaze() => Debug.Log("Quit Game");
}
