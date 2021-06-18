using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangePlace : MonoBehaviour
{
    /// <summary>
    /// Method to load 360CantinaTour Scene
    /// </summary>
    public void OnLoadCantina()
    {
        //The SceneManager loads your new Scene as a single Scene (not overlapping). This is Single mode.
        SceneManager.LoadScene("360CantinaTour", LoadSceneMode.Single);
    }

    /// <summary>
    /// Method to load 360CubeTour Scene
    /// </summary>
    public void OnLoadCube()
    {
        //The SceneManager loads your new Scene as a single Scene (not overlapping). This is Single mode.
        SceneManager.LoadScene("360CubeTour", LoadSceneMode.Single);
    }

    /// <summary>
    /// Method to load 360LivingTour Scene
    /// </summary>
    public void OnLoadLiving()
    {
        //The SceneManager loads your new Scene as a single Scene (not overlapping). This is Single mode.
        SceneManager.LoadScene("360LivingTour", LoadSceneMode.Single);
    }

    /// <summary>
    /// Method to load 360MezzanineTour Scene
    /// </summary>
    public void OnLoadMezzanine()
    {
        //The SceneManager loads your new Scene as a single Scene (not overlapping). This is Single mode.
        SceneManager.LoadScene("360MezzanineTour", LoadSceneMode.Single);
    }
}
