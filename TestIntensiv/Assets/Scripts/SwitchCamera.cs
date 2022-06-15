using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField]private GameObject playerCam;
    [SerializeField]private GameObject maincamera;

    public static Camera currentCamera;
    public static bool playerCamera = false;

    void Start()
    {
        playerCam.GetComponent<Camera>().enabled = false;
        playerCam.GetComponent<PhysicsRaycaster>().enabled = false;
        maincamera.GetComponent<Camera>().enabled = true;
        maincamera.GetComponent<PhysicsRaycaster>().enabled = true;
        currentCamera = maincamera.GetComponent<Camera>();
    }

    private void changeCam(int i)
    {
        if(i == 4)
        {
            playerCam.GetComponent<Camera>().enabled = false;
            playerCam.GetComponent<PhysicsRaycaster>().enabled = false;
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
            playerCam.GetComponent<Camera>().enabled = true;
            playerCam.GetComponent<PhysicsRaycaster>().enabled = true;
            currentCamera = playerCam.GetComponent<Camera>();
        }
    }
    public void changeCameToPlayer()
    {
        changeCam(2);
        Places.cameras.SetActive(false);
        Places.joysticks.SetActive(true);
        playerCamera = true;
    }

    public void changeCameToMain()
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
