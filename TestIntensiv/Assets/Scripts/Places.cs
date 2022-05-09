using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Places : MonoBehaviour
{
    public static GameObject info;
    public static GameObject infoaboutplace;
    public static GameObject currentObject;
    public static GameObject placeforObject;
    public static GameObject imageofmodel;
    public static GameObject nameofmodel;
    public static GameObject description;
    public static GameObject mainui;
    public static GameObject place1;
    public static GameObject place2;
    public static GameObject place3;
    public static GameObject descplace;
    public static GameObject canvas;
    public Sprite wrong;
    public static bool[] areas = { false, false, false };
    public static bool[] rigthareas = { false, false, false };

    private void Start()
    {
        info = GameObject.FindGameObjectWithTag("Info");
        infoaboutplace = GameObject.FindGameObjectWithTag("InfoAboutPlace");
        imageofmodel = GameObject.FindGameObjectWithTag("ImageOfModel");
        nameofmodel = GameObject.FindGameObjectWithTag("NameOfModel");
        description = GameObject.FindGameObjectWithTag("Description");
        mainui = GameObject.FindGameObjectWithTag("MainUI");
        place1 = GameObject.FindGameObjectWithTag("place1");
        place2 = GameObject.FindGameObjectWithTag("place2");
        place3 = GameObject.FindGameObjectWithTag("place3");
        descplace = GameObject.FindGameObjectWithTag("DescPlace");
        canvas = GameObject.FindGameObjectWithTag("OurCanvas");

        info.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
        {
            currentObject = Delete.currentObject;
            placeforObject = Delete.placeforobject;
            Destroy(currentObject);
            placeforObject.SetActive(true);
            if (placeforObject.tag == "kalancha")
            {
                areas[0] = false;
                rigthareas[0] = false;
                place1.GetComponent<Image>().sprite = wrong;
            }
            if (placeforObject.tag == "shark")
            {
                areas[1] = false;
                rigthareas[1] = false;
                place2.GetComponent<Image>().sprite = wrong;
            }
            if (placeforObject.tag == "gaup")
            {
                areas[2] = false;
                rigthareas[2] = false;
                place3.GetComponent<Image>().sprite = wrong;
            }
            DragPanel.returnElement(ref Delete.svc1, Delete.i);
            info.SetActive(false);
            mainui.SetActive(true);
            Delete.isClicked = false;
        });

        info.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() =>
        {
            info.SetActive(false);
            mainui.SetActive(true);
            Delete.isClicked = false;
        });

        infoaboutplace.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
        {
            infoaboutplace.SetActive(false);
            mainui.SetActive(true);
            InfoPlace.isCliked = false;
        });

        info.SetActive(false);
        infoaboutplace.SetActive(false);
    }
}
