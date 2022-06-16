using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LoadModels : MonoBehaviour
{
    public static bool isFirstPlay = true;
    public Sprite gvozd;

    [Serializable]
    public class ObjectFromDisk
    {
        public string Name;
        public string RusName;
        public string DescriptionObj;
        public string DescriptionPlace;
        public string BundleUrl;
        public float Size;
        public float Rotation;
        public float x;
        public float y;
    }

    [Serializable]
    public class GameModels
    {
        public ObjectFromDisk[] models;
    }

    GameModels Models;

    void Start()
    {
        AssetBundle.UnloadAllAssetBundles(true);
        DragPanel.models.Clear();
        DragPanel.images.Clear();
        DragPanel.names.Clear();
        DragPanel.rusnames.Clear();
        DragPanel.descriptionobj.Clear();
        DragPanel.descriptionplace.Clear();
        DragPanel.size.Clear();
        DragPanel.rotation.Clear();
        DragPanel.x.Clear();
        DragPanel.z.Clear();

        StartCoroutine(GetObjects());
    }

    IEnumerator GetObjects()
    {
        string url = LinkToJSON.url;

        UnityWebRequest request = UnityWebRequest.Get(url);

        yield return request.SendWebRequest();
        
        if(request.isNetworkError)
        {
            Debug.Log("Нет интернета!");
            SceneManager.LoadScene(0);
        }
        else
        {
            if(request.isDone)
            {
                Debug.Log("Получено!");
                Debug.Log(request.downloadHandler.text);
                try
                {
                    Models = JsonUtility.FromJson<GameModels>(request.downloadHandler.text);
                }
                catch
                {
                    SceneManager.LoadScene(0);
                }
                StartCoroutine(GetModelsAndSprites());
            }
        }
    }

    IEnumerator GetModelsAndSprites()
    {
        for(int i = 0; i < Models.models.Length && i < 10; i++)
        {
            while (!Caching.ready)
                yield return null;

            WWW w = new WWW(Models.models[i].BundleUrl);
            yield return w;

            if (w.error != null)
            {
                Debug.Log("Не удалось загрузить бандл");
                SceneManager.LoadScene(0);
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
                    DragPanel.names.Add(Models.models[i].Name);
                    DragPanel.rusnames.Add(Models.models[i].RusName);
                    DragPanel.descriptionobj.Add(Models.models[i].DescriptionObj);
                    DragPanel.descriptionplace.Add(Models.models[i].DescriptionPlace);
                    DragPanel.size.Add(Models.models[i].Size);
                    DragPanel.rotation.Add(Models.models[i].Rotation);
                    DragPanel.x.Add(Models.models[i].x);
                    DragPanel.z.Add(Models.models[i].y);
                }
            }
        }
        SceneManager.LoadScene(2);
    }
}
