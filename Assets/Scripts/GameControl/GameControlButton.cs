using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlButton : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject GameControlMenu;
    void Update()
    {
        if (Input.GetButtonDown("Pause") || Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
            GameControlMenu.SetActive(true);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        isPaused = true;
    }
    public void ResumeGame()
    {
        GameControlMenu.SetActive(false);

        Time.timeScale = 1;
        AudioListener.pause = false;
        isPaused = false;
    }

    public void Reload()
    {
        GameControlMenu.SetActive(false);
        //Application.LoadLevel(Application.loadedLevel);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (isPaused)
        {
            ResumeGame();
        }

    }

}
