using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfoPlace : MonoBehaviour, IPointerDownHandler
{
    public static bool isCliked = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isCliked)
        {
            int i = DragPanel.names.IndexOf(transform.name);
            setTextOnPanel(DragPanel.descriptionplace[i]);
            isCliked = true;
            Places.mainui.SetActive(false);
            Places.info.SetActive(false);
            Places.instruction.SetActive(false);
            Delete.isClicked = false;
        }
    }

    private void setTextOnPanel(string text)
    {
        Places.infoaboutplace.SetActive(true);
        Places.descplace.GetComponent<Text>().text = text;
    }
}
