using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // scene
    public void EnterScene(int index)
    {
        SceneManager.LoadScene(index);
        UnpauseGame();
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Exit");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }
}
