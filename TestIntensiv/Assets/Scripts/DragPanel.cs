using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragPanel : MonoBehaviour
{
    [SerializeField] private GameObject dragModelPrefab;
    [SerializeField] private Transform scrollViewContent;
    public static List<GameObject> models = new List<GameObject>();
    public static List<Sprite> images = new List<Sprite>();
    public static List<string> names = new List<string>();
    public static List<string> description = new List<string>();

    private void Start()
    {
        for(int i = 0; i < models.Count; i++)
        {
            var dragObject = Instantiate(dragModelPrefab, scrollViewContent);
            var script = dragObject.GetComponent<DragElement>();
            script.MainImage.sprite = images[i];            
            script.MainTransform = models[i];
            script.Index = i;
            script.DefaultParentTransform = scrollViewContent;
            script.DragModelPrefab = dragModelPrefab;
            script.DragParentTransform = transform;
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
