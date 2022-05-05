using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Places : MonoBehaviour
{
    public static GameObject delete;
    public static GameObject currentObject;
    public static GameObject placeforObject;
    public static bool areaForKalancha = false;
    public static bool areaForSobaka = false;

    private void Start()
    {
        delete = GameObject.FindGameObjectWithTag("DeleteObject");
        delete.SetActive(false);
        delete.GetComponent<Button>().onClick.AddListener(() =>
        {
            currentObject = Delete.currentObject;
            placeforObject = Delete.placeforobject;
            Destroy(currentObject);
            placeforObject.SetActive(true);
            if (placeforObject.tag == "AreaForKalancha")
            {
                Places.areaForKalancha = false;
            }
            else if (placeforObject.tag == "AreaForSobaka")
            {
                Places.areaForSobaka = false;
            }
            DragPanel.returnElement(ref Delete.svc1, Delete.i);
            delete.SetActive(false);
            Delete.isClicked = false;
        }
);
        delete.SetActive(false);
    }
}
