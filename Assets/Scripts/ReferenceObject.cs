using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReferenceObject : MonoBehaviour
{
    public ChangeForBackGround change;
    public Img img;
    public RawImage image;

    public void Start()
    {
        img = GetComponent<Img>();
    }

    public void SetObject()
    {
        if(img.connectImage != null)
        {
        change.obj = img.connectImage.gameObject;
        image.texture = img.connectImage.texture;
        }
    }
}
