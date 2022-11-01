using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMax : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public bool isMin;

    public void ButtonPress()
    {

        if (isMin)
        {
            obj.SetActive(false);
            obj2.SetActive(true);
        }

        if (!isMin)
        {
            obj.SetActive(true);
            obj2.SetActive(false);
        }
    }

}
