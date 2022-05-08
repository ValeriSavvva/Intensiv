using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfoPlace : MonoBehaviour, IPointerDownHandler
{
    private static string[] descriptions = new string[] { 
    "� ��� ��� ������ �����-�� ���� �����, �������� �������� � ������� - ������ ����",
    "�� ���� ����� �����-�� ������ ������, ������� ������������� ��� ������� �������, �� ��� �������"
    };

    public static bool isCliked = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isCliked)
        {
            if (transform.tag == "shark")
                setTextOnPanel(0);
            if (transform.tag == "kalancha")
                setTextOnPanel(1);
            isCliked = true;
        }
    }

    private void setTextOnPanel(int i)
    {
        Places.infoaboutplace.SetActive(true);
        Places.descplace.GetComponent<Text>().text = descriptions[i];
    }
}
