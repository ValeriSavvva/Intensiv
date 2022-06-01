using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LinkToJSON : MonoBehaviour
{
    public static string url = "https://drive.google.com/uc?export=download&id=1cNX4Xdj86Xi57Ld-K-OVEAZavVbRxxzr";
    public InputField text;

    private void Start()
    {
        string saveUrl = PlayerPrefs.GetString("url");
        if (!saveUrl.Equals(""))
            url = saveUrl;
        text.text = url;
    }

    public void save()
    {
        url = text.text;
        PlayerPrefs.SetString("url", url);
        SceneManager.LoadScene(0);
        LoadModels.isFirstPlay = true;
        AssetBundle.UnloadAllAssetBundles(true);
    }
    
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
