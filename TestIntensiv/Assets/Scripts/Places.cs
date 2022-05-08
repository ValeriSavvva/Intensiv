using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Places : MonoBehaviour
{
    public static GameObject info;
    public static GameObject currentObject;
    public static GameObject placeforObject;
    public static GameObject imageofmodel;
    public static GameObject nameofmodel;
    public static GameObject description;
    public static GameObject mainui;
    public static GameObject place1;
    public static GameObject place2;
    public static bool areaForKalancha = false;
    public static bool areaForSobaka = false;

    private void Start()
    {
        info = GameObject.FindGameObjectWithTag("Info");
        imageofmodel = GameObject.FindGameObjectWithTag("ImageOfModel");
        nameofmodel = GameObject.FindGameObjectWithTag("NameOfModel");
        description = GameObject.FindGameObjectWithTag("Description");
        mainui = GameObject.FindGameObjectWithTag("MainUI");
        place1 = GameObject.FindGameObjectWithTag("place1");
        place2 = GameObject.FindGameObjectWithTag("place2");
        info.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
        {
            currentObject = Delete.currentObject;
            placeforObject = Delete.placeforobject;
            Destroy(currentObject);
            placeforObject.SetActive(true);
            if (placeforObject.tag == "kalancha")
            {
                Places.areaForKalancha = false;
                Places.place1.GetComponent<Image>().color = new Color(255, 0, 0);
            }
            else if (placeforObject.tag == "shark")
            {
                Places.areaForSobaka = false;
                Places.place2.GetComponent<Image>().color = new Color(255, 0, 0);
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
        info.SetActive(false);
    }
}
