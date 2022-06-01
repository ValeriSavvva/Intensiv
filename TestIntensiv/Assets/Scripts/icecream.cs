using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class icecream : MonoBehaviour, IPointerClickHandler
{
    public Material[] materials;
    int i = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        transform.GetComponent<Renderer>().material = materials[i];
        i++;
        if (i == 4)
            i = 0;
    }
}
