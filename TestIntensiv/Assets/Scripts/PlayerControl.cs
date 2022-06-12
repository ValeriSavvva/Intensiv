using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 7f;
    public Joystick joystick;
    private float vertical;
    private float horizontal;

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        vertical = joystick.Vertical;
        horizontal = joystick.Horizontal;
        if(vertical >= 0.5)
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
}
