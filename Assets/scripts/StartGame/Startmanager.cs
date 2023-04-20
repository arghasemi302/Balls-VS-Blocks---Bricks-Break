using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmanager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(0); 
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
