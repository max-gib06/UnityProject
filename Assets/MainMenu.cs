using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("OverWorld");

    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
