using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LoadModels : MonoBehaviour
{
    public struct ObjectFromDisk
    {
        public string Name;
        public string BundleUrl;
    }

    ObjectFromDisk[] models;
    public GameObject bt;

    void Start()
    {
        StartCoroutine(GetObjects());
        bt.SetActive(true);
    }

    public void nextScene()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator GetObjects()
    {
        string url = "https://drive.google.com/uc?export=download&id=1LaG9o_VCmOV_i-dRaMaCmlVlkaqCCAjL";

        UnityWebRequest request = UnityWebRequest.Get(url);

        yield return request.SendWebRequest();
        
        if(request.isNetworkError)
        {
            Debug.Log("Нет интернета!");
        }
        else
        {
            if(request.isDone)
            {
                Debug.Log("Получено!");
                models = JsonHelper.GetArray<ObjectFromDisk>(request.downloadHandler.text);
                Debug.Log(request.downloadHandler.text);
                StartCoroutine(GetModelsAndSprites());
            }
        }
    }

    IEnumerator GetModelsAndSprites()
    {
        for(int i = 0; i < models.Length; i++)
        {
            var w = WWW.LoadFromCacheOrDownload(models[i].BundleUrl, 0);
            yield return w;

            if (w.error != null)
            {
                Debug.Log("Не удалось загрузить бандл");
            }
            else
            {
                if(w.isDone)
                {
                    var assetBundle = w.assetBundle;
                    string model = models[i].Name + ".fbx";
                    string sprite = models[i].Name + ".png";

                    var modelRequest = assetBundle.LoadAssetAsync(model, typeof(GameObject));
                    yield return modelRequest;
                    var spriteRequest = assetBundle.LoadAssetAsync(sprite, typeof(Sprite));
                    yield return spriteRequest;

                    DragPanel.models.Add(modelRequest.asset as GameObject);
                    DragPanel.images.Add(spriteRequest.asset as Sprite);
                }
            }
        }
    }
}
