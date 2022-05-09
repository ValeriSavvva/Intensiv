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

        text.text = $"��������� ���������� {count} �� {Places.rigthareas.Length} ����������";
    }

    public void exit()
    {
        Application.Quit();
    }
}
