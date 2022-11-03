using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTextures : MonoBehaviour
{
    public GameObject imageInst;
    public ChangeAsset button;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
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
