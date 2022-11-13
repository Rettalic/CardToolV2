using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Listing : MonoBehaviour
{
    public List<GameObject> imgList;
    public List<GameObject> imgList2;

    public GameObject parent1;
    public GameObject parent2;

    public GameObject baseObj;

    public GameObject imageInst;
    public ChangeAsset button;
    public int index = 0;

    public int startAmount;


    public void Start()
    {
        for (int i = 0; i < startAmount; i++)
        {
            CreateImgInst();
        }
    }

    public void CreateImgInst()
    {
        //PLAATJE
        var obj = Instantiate(baseObj, transform);
        obj.transform.SetParent(parent1.transform, false);

        //BUTTON
        GameObject newObj = Instantiate(imageInst, transform);
        GameObject pickObj = newObj.transform.GetChild(1).gameObject;
        GameObject indexObj = newObj.transform.GetChild(0).gameObject;
        button.pickButtons.Add(pickObj);
        button.indexButtons.Add(indexObj);
        newObj.transform.SetParent(parent2.transform, false);

        imgList.Add(newObj);
        imgList2.Add(obj);

        //CONNECT
        imgList[index].GetComponent<Img>().connectImage = imgList2[index].GetComponent<RawImage>();

        index = index + 1;
    }


}
