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

    private GameObject dragModelPrefab;
    public GameObject DragModelPrefab
    {
        get { return dragModelPrefab; }
        set
        {
            if (value != null)
            {
                dragModelPrefab = value;
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

    public Sprite RigthImage;

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(DragParentTransform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / Places.canvas.GetComponent<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(DefaultParentTransform);
        transform.SetSiblingIndex(index);

        Ray ray = SwitchCamera.currentCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if(DragPanel.names.Contains(hit.transform.name))
            {
                hit.transform.gameObject.SetActive(false);

                int i = DragPanel.names.IndexOf(hit.transform.name);
                placeObject(hit, DragPanel.rotation[i], DragPanel.size[i]);

                if(MainTransform.name.Equals(hit.transform.name))
                {
                    Places.place[i].GetComponent<Image>().sprite = RigthImage;
                    Places.rigthareas[i] = true;
                }
                Places.areas[i] = true;
            }           
        }
    }

    private void placeObject(RaycastHit hit, float rotation, float scale)
    {
        GameObject newObj = Instantiate(MainTransform,
            new Vector3(hit.transform.position.x,
            hit.transform.position.y + 0.01f,
            hit.transform.position.z),
            Quaternion.identity) as GameObject;
        Transform svc = transform.parent;
        newObj.AddComponent<BoxCollider>().size = new Vector3(4f, 4f, 4f);
        newObj.GetComponent<BoxCollider>().center = new Vector3(0, 1f, 0);
        newObj.AddComponent<Delete>().enabled = true;
        newObj.GetComponent<Delete>().currentGO = newObj;
        newObj.GetComponent<Delete>().index = Index;
        newObj.GetComponent<Delete>().plane = hit.transform.gameObject;
        newObj.GetComponent<Delete>().svc = svc;
        newObj.transform.Rotate(new Vector3(MainTransform.transform.rotation.x,
            rotation,
            MainTransform.transform.rotation.z), 
            Space.World);
        newObj.transform.localScale = new Vector3(MainTransform.transform.localScale.x * scale,
            MainTransform.transform.localScale.y * scale,
            MainTransform.transform.localScale.z * scale);
        DragPanel.deleteElement(ref svc, Index);
    }
}
