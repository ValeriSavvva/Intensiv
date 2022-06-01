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
        if(LoadModels.isFirstPlay)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(2);
    }
}
