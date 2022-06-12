using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField]private GameObject[] cm;
    [SerializeField]private GameObject maincamera;

    public static Camera currentCamera;
    public static bool playerCamera = false;

    void Start()
    {
        for (int i = 0; i < cm.Length; i++)
        {
            cm[i].GetComponent<Camera>().enabled = false;
            cm[i].GetComponent<PhysicsRaycaster>().enabled = false;
        }
        maincamera.GetComponent<Camera>().enabled = true;
        maincamera.GetComponent<PhysicsRaycaster>().enabled = true;
        currentCamera = maincamera.GetComponent<Camera>();
    }

    private void changeCam(int i)
    {
        if(i == 4)
        {
            for (i = 0; i < cm.Length; i++)
            {
                cm[i].GetComponent<Camera>().enabled = false;
                cm[i].GetComponent<PhysicsRaycaster>().enabled = false;
            }
            maincamera.GetComponent<Camera>().enabled = true;
            maincamera.GetComponent<PhysicsRaycaster>().enabled = true;
            CameraRotation.cameraRotationBlock = false;
            currentCamera = maincamera.GetComponent<Camera>();
        }
        else
        {
            maincamera.GetComponent<Camera>().enabled = false;
            maincamera.GetComponent<PhysicsRaycaster>().enabled = false;
            CameraRotation.cameraRotationBlock = true;
            for (int j = 0; j < cm.Length; j++)
            {
                if (j != i)
                {
                    cm[j].GetComponent<Camera>().enabled = false;
                    cm[j].GetComponent<PhysicsRaycaster>().enabled = false;
                }
                else
                {
                    cm[j].GetComponent<Camera>().enabled = true;
                    cm[j].GetComponent<PhysicsRaycaster>().enabled = true;
                    currentCamera = cm[j].GetComponent<Camera>();
                }
            }
        }
    }

    public void changeCamåToFirst()
    {
        changeCam(0);
    }

    public void changeCamåToSecond()
    {
        changeCam(1);
    }

    public void changeCamåToPlayer()
    {
        changeCam(2);
        Places.cameras.SetActive(false);
        Places.joysticks.SetActive(true);
        playerCamera = true;
    }

    public void changeCamåToMain()
    {
        changeCam(4);
    }

    public void backToMain()
    {
        changeCam(4);
        Places.cameras.SetActive(true);
        Places.joysticks.SetActive(false);
        playerCamera = false;
    }
}
