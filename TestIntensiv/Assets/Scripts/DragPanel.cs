using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragPanel : MonoBehaviour
{
    [SerializeField] private GameObject dragModelPrefab;
    [SerializeField] private GameObject cilinder;
    [SerializeField] private Transform scrollViewContent;
    [SerializeField] private Sprite RigthImage;
    public static List<GameObject> models = new List<GameObject>();
    public static List<Sprite> images = new List<Sprite>();
    public static List<string> names = new List<string>();
    public static List<string> rusnames = new List<string>();
    public static List<string> descriptionobj = new List<string>();
    public static List<string> descriptionplace = new List<string>();
    public static List<float> size = new List<float>();
    public static List<float> rotation = new List<float>();
    public static List<float> x = new List<float>();
    public static List<float> z = new List<float>();

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
            script.RigthImage = RigthImage;
            var obj = Instantiate(cilinder, new Vector3(x[i], 1.025f, z[i]), Quaternion.identity);
            obj.transform.localScale = new Vector3(size[i] * 4f, 0.1f, size[i] * 4f);
            obj.transform.name = names[i];
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
