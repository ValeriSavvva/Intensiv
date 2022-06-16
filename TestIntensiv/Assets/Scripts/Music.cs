using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{

    public Sprite PlayMusic;
    public Sprite PauseMusic;
    public Image image;
    public AudioSource music;

    bool isStoped = false;

    public void click()
    {
        isStoped = !isStoped;
        if(isStoped)
        {
            music.Pause();
            image.sprite = PauseMusic;
        }
        else
        {
            music.Play();
            image.sprite = PlayMusic;
        }
    }
}
