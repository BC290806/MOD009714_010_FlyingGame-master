using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControllerScript : MonoBehaviour
{
    [System.Obsolete]
    public void PlayGame()
    {
        SceneManager.LoadScene("GameMode");
    }

    public void QuitGame()
    {
        Debug.Log("Game Quitted");
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("GameMode");
    }
}
