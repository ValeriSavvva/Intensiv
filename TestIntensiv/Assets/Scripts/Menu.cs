using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void exit()
    {
        Application.Quit();
    }

    public void startgame()
    {
        SceneManager.LoadScene(1);
    }

    public void setting()
    {
        SceneManager.LoadScene(5);
    }
}
