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
            script.DragParentTransform = transform;
        }
    }

    public static void deleteElement(ref Transform svc, int i)
    {
        Destroy(svc.GetChild(i).gameObject);
    }
}
