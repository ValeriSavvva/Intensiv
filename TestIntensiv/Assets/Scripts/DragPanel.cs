using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragPanel : MonoBehaviour
{
    [SerializeField] private GameObject dragModelPrefab;
    [SerializeField] private Transform scrollViewContent;
    [SerializeField] private List<GameObject> models;
    [SerializeField] private List<Sprite> images;
    public static List<string> tags = new List<string>();
    static List<GameObject> objects = new List<GameObject>();

    private void Start()
    {
        tags.Add("shark");
        tags.Add("kalancha");
        for(int i = 0; i < models.Count; i++)
        {
            var dragObject = Instantiate(dragModelPrefab, scrollViewContent);
            var script = dragObject.GetComponent<DragElement>();
            script.MainImage.sprite = images[i];            
            script.MainTransform = models[i];
            script.MainTransform.transform.tag = tags[i];
            script.Index = i;
            script.DefaultParentTransform = scrollViewContent;
            script.DragModelPrefab = dragModelPrefab;
            script.DragParentTransform = transform;
            objects.Add(dragObject);
        }
    }

    public static void deleteElement(ref Transform svc, int i)
    {
        svc.GetChild(i).gameObject.SetActive(false);
    }

    public static void returnElement(ref Transform svc, int i)
    {
        svc.GetChild(i).gameObject.SetActive(true);
    }
}
