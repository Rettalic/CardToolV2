using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using AnotherFileBrowser.Windows;

public class FileManager : MonoBehaviour
{
    public RawImage[] imgList;
    public int changeIndex;
    public RawImage img;
    public Img im;

    public void OpenFileBrowser(int index)
    {
        var bp = new BrowserProperties();
        bp.filterIndex = 0;

        new FileBrowser().OpenFileBrowser(bp, path =>
        {
            StartCoroutine(LoadImage(path, index));
        });
    }

    public IEnumerator LoadImage(string path, int index)
    {
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(path))
        {
            yield return uwr.SendWebRequest();

            if(uwr.isNetworkError || uwr.isHttpError) Debug.Log(uwr.error);
            else
            {
                var uwrTex = DownloadHandlerTexture.GetContent(uwr);
                imgList[index].texture = uwrTex;
            }
        }
    }

    public void SetImg(int index)
    {
        im.image.texture = imgList[index].texture;
    }

    

}
