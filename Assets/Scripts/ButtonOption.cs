using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene((int)Enumeration.SceneBuilderIndex.PlayGame);
    }

    public void RandomGame()
    {
        var r = new System.Random();
        GlobalCar.CarType = r.Next(1, 2);
        SceneManager.LoadScene(r.Next(4, 6));
    }

    public void MainMenu()
    {
        SceneManager.LoadScene((int)Enumeration.SceneBuilderIndex.MainMenu);
    }

    // Below here are track selection buttons
    public void Track01()
    {
        SceneManager.LoadScene((int)Enumeration.SceneBuilderIndex.Track01);
    }

    public void Track02()
    {
        SceneManager.LoadScene((int)Enumeration.SceneBuilderIndex.Track02);
    }

    public void Track03()
    {
        SceneManager.LoadScene((int)Enumeration.SceneBuilderIndex.Track03);
    }

    public void Credits()
    {
        SceneManager.LoadScene((int)Enumeration.SceneBuilderIndex.Credit);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
