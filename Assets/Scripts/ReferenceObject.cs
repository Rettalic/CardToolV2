using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceObject : MonoBehaviour
{
    public ChangeForBackGround change;
    public Img img;

    public void Start()
    {
        img = GetComponent<Img>();
    }

    public void SetObject()
    {
        change.obj = img.connectImage.gameObject;
    }
}
