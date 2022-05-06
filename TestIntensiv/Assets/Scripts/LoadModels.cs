using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LoadModels : MonoBehaviour
{
    [Serializable]
    public class ObjectFromDisk
    {
        public string Name;
        public string BundleUrl;
    }

    [Serializable]
    public class GameModels
    {
        public ObjectFromDisk[] models;
    }

    GameModels Models;
    public GameObject bt;

    void Start()
    {
        StartCoroutine(GetObjects());
    }

    public void nextScene()
    {
        SceneManager.LoadScene(1);
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
                Models = JsonUtility.FromJson<GameModels>(request.downloadHandler.text);
                for(int i = 0; i < Models.models.Length; i++)
                {
                    Debug.Log(Models.models[i].Name);
                    Debug.Log(Models.models[i].BundleUrl);
                }
                Debug.Log(request.downloadHandler.text);
                StartCoroutine(GetModelsAndSprites());
            }
        }
    }

    IEnumerator GetModelsAndSprites()
    {
        for(int i = 0; i < Models.models.Length; i++)
        {
            while (!Caching.ready)
                yield return null;

            WWW w = new WWW(Models.models[i].BundleUrl);
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
                    string model = Models.models[i].Name + ".fbx";
                    string sprite = Models.models[i].Name + ".png";

                    var modelRequest = assetBundle.LoadAssetAsync(model, typeof(GameObject));
                    yield return modelRequest;
                    var spriteRequest = assetBundle.LoadAssetAsync(sprite, typeof(Sprite));
                    yield return spriteRequest;

                    DragPanel.models.Add(modelRequest.asset as GameObject);
                    DragPanel.images.Add(spriteRequest.asset as Sprite);
                }
            }
        }
        bt.SetActive(true);
    }
}
