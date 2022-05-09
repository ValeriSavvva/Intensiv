using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject reload;
    public GameObject instruction;
    public GameObject exit;

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
}
