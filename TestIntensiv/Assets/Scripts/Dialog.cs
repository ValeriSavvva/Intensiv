using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public GameObject text;
    public GameObject panel;
    public GameObject cards;
    public GameObject button;
    public GameObject ModelPrefab;
    public Transform scrollViewContent;

    private int i = 0;

    private string[] replics = { "��� �������� ������� ���������� �� ������� ������ �����. � ��� ��� � ������� ��� �������� �������� ������������� ����������� � ����. ������������ ����� ����� �� ��������, ��������� ����� � ���������.",
                                 "��� ����� ������������ ���� ������ ��� ������ ����������  ����������� �������. ��� ������ ���� ��������� ���������������,  ����� �� ���� ������� �� ������� ������� ��������� ������. �������� ������ �����! �� ������� ��� �������� � ����������� � ���������� ��������."};
    private string[] answers = { "����� ����! ��� ��� ������?",
                                 "������ ���������!",
                                 "������� ���������!"};

    public void Start()
    {
        text.GetComponent<Text>().text = replics[i];
        button.GetComponent<Text>().text = answers[i];
        i++;

        for (int i = 0; i < DragPanel.models.Count; i++)
        {
            var dragObject = Instantiate(ModelPrefab, scrollViewContent);
            var script = dragObject.GetComponent<Card>();
            script.image.sprite = DragPanel.images[i];
            script.name.text = DragPanel.rusnames[i];
            script.desc.text = DragPanel.descriptionobj[i];
        }
    }

    public void next()
    {
        if(i == 1)
        {
            text.GetComponent<Text>().text = replics[i];
            button.GetComponent<Text>().text = answers[i];
        }
        if (i == 2)
        {
            panel.SetActive(false);
            cards.SetActive(true);
            button.GetComponent<Text>().text = answers[i];
        }
        if (i == 3)
        {
            SceneManager.LoadScene(3);
            Debug.Log("������");
        }
        i++;
    }
}
