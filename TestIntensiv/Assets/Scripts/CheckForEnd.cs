using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForEnd : MonoBehaviour
{
    public GameObject end;

    public void Update()
    {
        check();
    }

    private void check()
    {
        for (int i = 0; i < Places.areas.Length; i++)
        {
            if (!Places.areas[i])
            {
                end.SetActive(false);
                return;
            }
        }

        end.SetActive(true);
    }

    public void confirm()
    {
        SceneManager.LoadScene(4);
    }
}
