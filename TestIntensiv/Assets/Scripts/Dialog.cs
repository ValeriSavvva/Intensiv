using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public GameObject text;
    public GameObject button;

    private int i = 0;

    private string[] replics = { "��� �������� ������� ���������� �� ������� ������ �����. � ��� ��� � ������� ��� �������� �������� ������������� ����������� � ����. ������������ ����� ����� �� ��������, ��������� ����� � ���������.",
                                 "��� ����� ������������ ���� ������ ��� ������ ����������  ����������� �������. ��� ������ ���� ��������� ���������������,  ����� �� ���� ������� �� ������� ������� ��������� ������. �������� ������ �����!"};
    private string[] answers = { "����� ����! ��� ��� ������?",
                                 "������� ���������!"};

    public void Start()
    {
        text.GetComponent<Text>().text = replics[i];
        button.GetComponent<Text>().text = answers[i];
        i++;
    }

    public void next()
    {
        if(i == 1)
        {
            text.GetComponent<Text>().text = replics[i];
            button.GetComponent<Text>().text = answers[i];
        }
        if (i == 2)
            SceneManager.LoadScene(1);
        i++;
    }
}
