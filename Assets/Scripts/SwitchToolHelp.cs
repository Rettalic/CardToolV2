using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwitchToolHelp : MonoBehaviour
{
    public List<Image> images;
    public Image image;
    private int index = 0;
    private bool onOff = false;

    private void Start()
    {
        image.gameObject.SetActive(false);
        image.preserveAspect = true;
        image.sprite = images[index].sprite;
    }

    public void GoRight()
    {
        index++;
        if(index >= images.Count)
        {
            index = 0;
        }
        image.sprite = images[index].sprite;
    }

    public void GoLeft()
    {
        index--;
        if(index < images.Count)
        {
            index = images.Count;
        }
        image.sprite = images[index].sprite;
    }

    public void HelpButton()
    {
        if (!onOff)
        {
            image.gameObject.SetActive(true);
            onOff = true;
        }
        else
        {
            image.gameObject.SetActive(false);
            onOff = false;
        }
    }
}
