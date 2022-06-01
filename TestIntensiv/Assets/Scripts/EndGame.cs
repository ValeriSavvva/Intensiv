using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    public void main()
    {
        SceneManager.LoadScene(0);
        for (int i = 0; i < Places.areas.Length; i++)
            Places.areas[i] = false;

        for (int i = 0; i < Places.rigthareas.Length; i++)
            Places.rigthareas[i] = false;

        Delete.isClicked = false;
    }
    public void exit()
    {
        Application.Quit();
    }
}
