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
    public ChangePos changePos;
    public GameObject old;

    private void Start()
    {
        image = GetComponent<RawImage>();
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
        old = moveObject.obj;
        moveObject.obj = connectImage.gameObject;
        changePos.asset = connectImage.gameObject;

        moveObject.obj.transform.localScale    = old.transform.localScale;
        moveObject.obj.transform.localPosition = old.transform.localPosition;
        moveObject.obj.transform.localRotation = old.transform.localRotation;
    }
}
