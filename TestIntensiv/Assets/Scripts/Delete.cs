using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Delete : MonoBehaviour, IPointerDownHandler
{
    public GameObject plane;
    public static GameObject placeforobject;
    public int index;
    public static int i;
    public GameObject currentGO;
    public static GameObject currentObject;
    public Transform svc;
    public static Transform svc1;
    public GameObject info;

    public static bool isClicked;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isClicked)
        {
            Debug.Log("Нажал");
            info.SetActive(true);
            Places.mainui.SetActive(false);
            Places.infoaboutplace.SetActive(false);
            InfoPlace.isCliked = false;
            Places.instruction.SetActive(false);
            isClicked = true;
            i = index;
            currentObject = currentGO;
            placeforobject = plane;
            Places.imageofmodel.GetComponent<Image>().sprite = DragPanel.images[i];
            Places.nameofmodel.GetComponent<Text>().text = DragPanel.rusnames[i];
            Places.description.GetComponent<Text>().text = DragPanel.descriptionobj[i];
        }
    }

    private void Start()
    {
        isClicked = false;
        svc1 = svc;
        info = Places.info;
    }
}
