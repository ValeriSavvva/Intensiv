using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    public void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Places.areaForShark = false;
        Places.areaForTable = false;
    }
    
    public void exit()
    {
        Application.Quit();
    }
}
