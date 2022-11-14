using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Img : MonoBehaviour
{
    public FileManager fMan;
    public RawImage image;
    public RawImage connectImage;
    public ChangePos changePos;

    private void Start()
    {
        image = GetComponent<RawImage>();
    }
    public void Update()
    {
        if(image != null && connectImage != null) connectImage.texture = image.texture;
    }

    public void SetScript()
    {
        fMan.im = this;
    }


    public void SetMoveObject()
    {
        changePos.sliderR.value = connectImage.gameObject.transform.localRotation.z;
        changePos.sliderS.value = connectImage.gameObject.transform.localScale.z;
        changePos.sliderX.value = connectImage.gameObject.transform.position.x;
        changePos.sliderY.value = connectImage.gameObject.transform.position.y;

        changePos.asset = connectImage.gameObject;
    }
}
