using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CS_Win_Lvl : MonoBehaviour
{
    public string scene;
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene);
            Debug.Log("Win !");
        }
    }
}
