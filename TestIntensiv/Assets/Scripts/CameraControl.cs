using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensetivity = 150f;
    private float mouseX;
    private float mouseY;
    public Transform player;
    public Joystick joystick;

    void Update()
    {
        if (transform.GetComponent<Camera>().Equals(SwitchCamera.currentCamera))
        {
            mouseX = joystick.Horizontal * sensetivity * Time.deltaTime;
            mouseY = joystick.Vertical * sensetivity * Time.deltaTime;

            player.Rotate(mouseX * new Vector3(0, 1, 0));
            transform.Rotate(-mouseY * new Vector3(1, 0, 0));
        }
    }
}
