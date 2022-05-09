using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForEnd : MonoBehaviour
{
    private bool[] needToEnd = { false, false };
    public GameObject end;
    
    public void Update()
    {
        for(int i = 0; i < needToEnd.Length; i++)
        {
            needToEnd[i] = Places.areas[i];
        }

        check();
    }

    private void check()
    {
        for (int i = 0; i < needToEnd.Length; i++)
        {
            if (!needToEnd[i])
            {
                end.SetActive(false);
                return;
            }
        }

        end.SetActive(true);
    }

    public void confirm()
    {
        SceneManager.LoadScene(2);
    }
}
