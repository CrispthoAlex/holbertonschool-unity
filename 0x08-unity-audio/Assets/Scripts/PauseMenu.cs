using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PauseMenu : MonoBehaviour
{
    //public Button RestartButton;

    public GameObject pauseCanvas;
    bool paused = false;
    public Button ResumeButton;
    public Button RestartButton;
    public Button MenuButton;
    public Button OptionsButton;

    public void Start()
    {
        ResumeButton.onClick.AddListener(delegate
        {
            pauseCanvas.SetActive(false);
            Resume();
        });
        
        RestartButton.onClick.AddListener((Restart));
        
        MenuButton.onClick.AddListener((MainMenu));
        
        OptionsButton.onClick.AddListener((Options));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
        paused = true;
    }

    private void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        paused = false;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
