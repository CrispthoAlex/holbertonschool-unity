using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OptionsMenu : MonoBehaviour
{
    public SceneState sceneState;
    
    // function to return to the previous menu
    public void Back()
    {
        SceneManager.LoadScene(sceneState.previousScene);  
    }
}
