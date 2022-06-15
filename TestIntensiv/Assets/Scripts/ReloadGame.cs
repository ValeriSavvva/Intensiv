using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    public void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        for (int i = 0; i < Places.areas.Length; i++)
            Places.areas[i] = false;

        for (int i = 0; i < Places.rigthareas.Length; i++)
            Places.rigthareas[i] = false;

        Delete.isClicked = false;
        CameraRotation.cameraRotationBlock = false;
        SwitchCamera.playerCamera = false;
    }
    
    public void exit()
    {
        Application.Quit();
    }
}
