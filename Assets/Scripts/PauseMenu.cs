using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pauseUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
            if (GamePaused)
			{
                Resume();
			} else
			{
                Pause();
			}
		}
    }

    void Resume()
	{
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        GamePaused = false;
    }

    void Pause()
	{
        pauseUI.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;
	}

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Retry()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
