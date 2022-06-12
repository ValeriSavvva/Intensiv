using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    public Joystick joystick;
    private float vertical;
    private float horizontal;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            GetInput();
        else
            GetJoystickInput();
    }

    private void GetJoystickInput()
    {
        vertical = joystick.Vertical;
        horizontal = joystick.Horizontal;

        if (vertical >= 0.5)
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (vertical <= -0.5)
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }

        if (horizontal <= -0.5)
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

        if (horizontal >= 0.5)
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
    }

    private void GetInput()
    {

        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
    }
}
