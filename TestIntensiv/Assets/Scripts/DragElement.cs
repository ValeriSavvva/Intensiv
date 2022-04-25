using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragElement : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Image mainImage;
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public Image MainImage
    {
        get { return mainImage; }
        set
        {
            if (value != null)
            {
                mainImage = value;
            }
        }
    }

    private GameObject mainTransform; //3D объект
    public GameObject MainTransform
    {
        get { return mainTransform; }
        set
        {
            if(value != null)
            {
                mainTransform = value;
            }
        }
    }

    private Transform defaultParentTransform; 
    public Transform DefaultParentTransform
    {
        get { return defaultParentTransform; }
        set
        {
            if (value != null)
            {
                defaultParentTransform = value;
            }
        }
    }

    private int index;
    public int Index
    {
        get { return index; }
        set
        {
            if (value > 0)
            {
                index = value;
            }
        }
    }

    private Transform dragParentTransform; 
    public Transform DragParentTransform
    {
        get { return dragParentTransform; }
        set
        {
            if (value != null)
            {
                dragParentTransform = value;
            }
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(DragParentTransform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(DefaultParentTransform);
        transform.SetSiblingIndex(index);

        Ray ray = SwitchCamera.currentCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if (!SwitchCamera.currentCamera.Equals(Camera.main))
            {
                if (hit.transform.tag == "AreaForShark" && !Places.areaForShark)
                {
                    Debug.Log("Попал");
                    placeObject(hit, new Vector3(0f, 90.0f, 0.0f), new Vector3(3f, 3f, 3f));
                    Places.areaForShark = true;
                }
                else if(hit.transform.tag == "AreaForTable" && !Places.areaForTable)
                {
                    Debug.Log("Попал");
                    Places.areaForTable = true;
                    placeObject(hit, new Vector3(0f, -90.0f, 0.0f), new Vector3(1f, 1f, 1f));
                }
            }
        }
    }

    private void placeObject(RaycastHit hit, Vector3 rotation, Vector3 scale)
    {
        GameObject newObj = Instantiate(MainTransform,
            new Vector3(hit.transform.position.x,
            hit.transform.position.y + 0.01f,
            hit.transform.position.z),
            Quaternion.identity) as GameObject;

        newObj.transform.Rotate(rotation, Space.World);
        newObj.transform.localScale = scale;
        Transform svc = transform.parent;
        DragPanel.deleteElement(ref svc, transform.GetSiblingIndex());
    }
}
