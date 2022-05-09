using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text text;

    void Start()
    {
        int count = 0;
        for (int i = 0; i < Places.rigthareas.Length; i++)
        {
            if(Places.rigthareas[i])
                count++;
        }

        text.text = $"Правильно поставлено {count} из {Places.rigthareas.Length} памятников";
    }

    public void exit()
    {
        Application.Quit();
    }
}
