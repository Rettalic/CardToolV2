using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Img : MonoBehaviour
{
    public FileManager fMan;
    public RawImage image;

    private void Start()
    {
        image = GetComponentInParent<RawImage>();

    }
    public void SetScript()
    {
        fMan.im = this;
    }
}
