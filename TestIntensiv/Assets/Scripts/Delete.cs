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
    public GameObject delete;

    public static bool isClicked = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Нажал");
        if (isClicked)
        {
            delete.SetActive(false);
            isClicked = false;
        }
        else
        {
            delete.SetActive(true);
            isClicked = true;
        }
        i = index;
        currentObject = currentGO;
        placeforobject = plane;
    }
    public static void returnobj()
    {
        DragPanel.returnElement(ref svc1, i);
    }

    private void Start()
    {
        svc1 = svc;
        delete = Places.delete;
    }
}
