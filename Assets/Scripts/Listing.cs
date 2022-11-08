using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Listing : MonoBehaviour
{
    public List<Img> imgList;
    public List<GameObject> imgList2;

    public GameObject baseObj;

    public GameObject imageInst;
    public ChangeAsset button;

    public int index;


    public void AddToList(Img imgObj, GameObject img)
    {
        imgList.Add(imgObj);
        imgList2.Add(img);
    }

    public void InstantiateObject()
    {
        var obj = Instantiate(baseObj, transform);
    }

    public void CreateImgInst()
    {
        GameObject newObj = Instantiate(imageInst, transform);
        GameObject pickObj = newObj.transform.GetChild(1).gameObject;
        button.pickButtons.Add(pickObj);
        GameObject indexObj = newObj.transform.GetChild(0).gameObject;
        button.indexButtons.Add(indexObj);
    }
}
