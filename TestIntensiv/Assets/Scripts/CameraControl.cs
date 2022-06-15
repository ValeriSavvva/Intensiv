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
            mouseY = -(joystick.Vertical * sensetivity * Time.deltaTime);

            Vector3 playerRotation = mouseX * new Vector3(0, 1, 0);
            Vector3 cameraRotation = mouseY * new Vector3(1, 0, 0);

            player.Rotate(playerRotation);
            transform.Rotate(cameraRotation);

            Vector3 rot = transform.eulerAngles;
            rot.x = (rot.x > 180f) ? rot.x - 360f : rot.x;
            rot.x = Mathf.Clamp(rot.x, -80f, 80f);
            rot.z = 0f;

            Debug.Log(rot.x.ToString());

            transform.rotation = Quaternion.Euler(rot);

        }
    }
}
