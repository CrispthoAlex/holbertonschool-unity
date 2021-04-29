using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // level1 button
    public Button Level01;
    // level2 button
    public Button Level02;
    // level3 button
    public Button Level03;
    
    // exit button
    public Button ExitButton;

    public SceneState sceneState;

    // Start is called before the first frame update
    private void Start()
    {
        Level01.onClick.AddListener(delegate {LevelSelect(0); });
		Level02.onClick.AddListener(delegate {LevelSelect(1); });
        Level03.onClick.AddListener(delegate { LevelSelect(2); });
        ExitButton.onClick.AddListener(ExitPlatforms);
    }
    
    // function that loads the different levels
    private static void LevelSelect(int level)
    {

        SceneManager.LoadScene(level);
    }

    // method that loads the options
    public void Options()
    {
        sceneState.previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Options");
    }

    // method should close the game window
    // when the Quit button is pressed.
    private static void ExitPlatforms()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
