using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseUi;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;


    }

    public void Quitter()
    {
        Debug.Log("Quitter le jeu");
        Application.Quit();
    }
}
