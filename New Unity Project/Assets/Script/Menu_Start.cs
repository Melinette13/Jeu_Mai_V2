using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Start : MonoBehaviour
{
    public Button start;
    public Button quit;
    public string scene;
    void Start()
    {
        start.GetComponent<Button>().onClick.AddListener(StartGame);
        quit.GetComponent<Button>().onClick.AddListener(QuitGame);
    }
    public void StartGame()
    {

        SceneManager.LoadScene(scene);

    }

    public void QuitGame()
    {
        Application.Quit();

    }

}
