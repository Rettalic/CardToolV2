using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Img : MonoBehaviour
{
    public FileManager fMan;
    public RawImage image;
    public RawImage connectImage;
    public MoveObject moveObject;

    private void Start()
    {
        image = GetComponentInParent<RawImage>();

    }
    public void SetScript()
    {
        fMan.im = this;
    }

    public void Update()
    {
        if(image != null && connectImage != null) connectImage.texture = image.texture;
    }

    public void SetMoveObject()
    {
        moveObject.obj = connectImage.gameObject;
    }
}
