using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public static GameObject cameras;
    public static GameObject joysticks;
    public static GameObject descplace;
    public static GameObject canvas;
    public static GameObject instruction;
    public static GameObject[] place;
    public Sprite wrong;
    public static bool isFirstPlay;
    public static bool[] areas = { false };
    public static bool[] rigthareas = { false };

    private void Start()
    {
        int count = 0;
        info = GameObject.FindGameObjectWithTag("Info");
        infoaboutplace = GameObject.FindGameObjectWithTag("InfoAboutPlace");
        imageofmodel = GameObject.FindGameObjectWithTag("ImageOfModel");
        nameofmodel = GameObject.FindGameObjectWithTag("NameOfModel");
        description = GameObject.FindGameObjectWithTag("Description");
        mainui = GameObject.FindGameObjectWithTag("MainUI");
        descplace = GameObject.FindGameObjectWithTag("DescPlace");
        canvas = GameObject.FindGameObjectWithTag("OurCanvas");
        instruction = GameObject.FindGameObjectWithTag("Instruction");
        cameras = GameObject.FindGameObjectWithTag("dp");
        joysticks = GameObject.FindGameObjectWithTag("joysticks");

        place = GameObject.FindGameObjectsWithTag("pl");
        List<GameObject> listPlaces = new List<GameObject>(place);
        listPlaces = listPlaces.OrderBy(value => value.name).ToList();
        
        for(int i = 0; i < listPlaces.Count; i++)
        {
            place[i] = listPlaces[i];
        }


        for (int i = 0; i < place.Length; i++)
        {
            if (i >= DragPanel.models.Count)
                place[i].SetActive(false);
            else
                count++;
        }

        areas = new bool[count];
        rigthareas = new bool[count]; 

        //кнопка удаления (информация о объекте)
        info.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
        {
            currentObject = Delete.currentObject;
            placeforObject = Delete.placeforobject;
            Destroy(currentObject);
            placeforObject.SetActive(true);
            int i = DragPanel.names.IndexOf(placeforObject.name);
            Debug.Log(i.ToString());
            areas[i] = false;
            rigthareas[i] = false;
            place[i].GetComponent<Image>().sprite = wrong;
            DragPanel.returnElement(ref Delete.svc1, Delete.i);
            info.SetActive(false);
            mainui.SetActive(true);

            if (SwitchCamera.playerCamera)
                joysticks.SetActive(true);
            else
                cameras.SetActive(true);

            Delete.isClicked = false;
            CameraRotation.cameraRotationBlock = false;
        });

        //кнопка закрыть (информация о объекте)
        info.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() =>
        {
            info.SetActive(false);
            mainui.SetActive(true);

            if (SwitchCamera.playerCamera)
                joysticks.SetActive(true);
            else
                cameras.SetActive(true);

            Delete.isClicked = false;
            CameraRotation.cameraRotationBlock = false;
        });

        //кнопка закрыть (информация о месте)
        infoaboutplace.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
        {
            infoaboutplace.SetActive(false);
            mainui.SetActive(true);

            if (SwitchCamera.playerCamera)
                joysticks.SetActive(true);
            else
                cameras.SetActive(true);

            InfoPlace.isCliked = false;
            CameraRotation.cameraRotationBlock = false;
        });

        info.SetActive(false);
        infoaboutplace.SetActive(false);
        joysticks.SetActive(false);

        if (LoadModels.isFirstPlay)
        {
            mainui.SetActive(false);
            joysticks.SetActive(false);
            cameras.SetActive(false);
            CameraRotation.cameraRotationBlock = true;
        }
        else
        {
            mainui.SetActive(true);

            if (SwitchCamera.playerCamera)
                joysticks.SetActive(true);
            else
                cameras.SetActive(true);

            instruction.SetActive(false);
        }
        LoadModels.isFirstPlay = false;
    }
}
