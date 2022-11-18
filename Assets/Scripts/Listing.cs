using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Listing : MonoBehaviour
{
    public int startAmount;
    private int index = 0;
    public List<GameObject> buttonList;
    public List<GameObject> cardList;

    public GameObject cardParent;
    public GameObject buttonParent;

    public GameObject baseObj;

    public GameObject imageInst;
    public ChangeAsset button;



    public void Start()
    {
        for (int i = 0; i < startAmount; i++)
        {
            CreateImgInst();
        }
    }

    public void CreateImgInst()
    {
        //Image Setup
        GameObject obj = Instantiate(baseObj, transform);
        obj.transform.SetParent(cardParent.transform, false);


        //BUTTON
        GameObject buttonObj = Instantiate(imageInst, transform);
        GameObject pickObj = buttonObj.transform.GetChild(1).gameObject;
        GameObject indexObj = buttonObj.transform.GetChild(0).gameObject;

        //Add to button list to turn on and off
        button.pickButtons.Add(pickObj);
        button.indexButtons.Add(indexObj);
        buttonObj.transform.SetParent(buttonParent.transform, false);

        buttonList.Add(buttonObj);
        cardList.Add(obj);

        //CONNECT
        buttonList[index].GetComponent<Img>().connectImage = cardList[index].GetComponent<RawImage>();

        index = index + 1;
    }

    public void DeleteObject()
    {
        index--;
        Destroy(buttonList[index].gameObject);
        Destroy(cardList[index].gameObject);
        button.indexButtons.RemoveAt(index);
        button.pickButtons.RemoveAt(index);
        buttonList.RemoveAt(index);
        cardList.RemoveAt(index);
    }

}
