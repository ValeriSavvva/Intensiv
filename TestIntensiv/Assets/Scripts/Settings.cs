using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public GameObject reload;
    public GameObject instruction;
    public GameObject exit;
    public GameObject instructiontext;

    private bool isClicked = false;

    public void onSettingsClick()
    {
        if (!isClicked)
        {
            isClicked = true;
            reload.SetActive(true);
            instruction.SetActive(true);
            exit.SetActive(true);
        }
        else
        {
            isClicked = false;
            reload.SetActive(false);
            instruction.SetActive(false);
            exit.SetActive(false);
        }
    }

    public void show()
    {
        instructiontext.SetActive(true);
        Places.mainui.SetActive(false);
        Places.infoaboutplace.SetActive(false);
        InfoPlace.isCliked = false;
        Places.info.SetActive(false);
        Delete.isClicked = false;
    }
    
    public void close()
    {
        instructiontext.SetActive(false);
        Places.mainui.SetActive(true);
    }

    public void reloadgame()
    {
        SceneManager.LoadScene(0);
        for (int i = 0; i < Places.areas.Length; i++)
            Places.areas[i] = false;

        for (int i = 0; i < Places.rigthareas.Length; i++)
            Places.rigthareas[i] = false;

        Delete.isClicked = false;
    }
}
