using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField]private Camera[] cm;
    [SerializeField]private Camera maincamera;

    public static Camera currentCamera;

    void Start()
    {
        for (int i = 0; i < cm.Length; i++)
        {
            cm[i].enabled = false;
        }
        maincamera.enabled = true;
        currentCamera = maincamera;
    }

    private void changeCam(int i)
    {
        if(i == 4)
        {
            for (i = 0; i < cm.Length; i++)
            {
                cm[i].enabled = false;
            }
            maincamera.enabled = true;
            currentCamera = maincamera;
        }
        else
        {
            maincamera.enabled = false;
            for (int j = 0; j < cm.Length; j++)
            {
                if (j != i)
                    cm[j].enabled = false;
                else
                {
                    cm[j].enabled = true;
                    currentCamera = cm[j];
                }
            }
        }
    }

    public void changeCam�ToFirst()
    {
        changeCam(0);
    }

    public void changeCam�ToSecond()
    {
        changeCam(1);
    }

    public void changeCam�ToThird()
    {
        changeCam(2);
    }

    public void changeCam�ToMain()
    {
        changeCam(4);
    }
}
