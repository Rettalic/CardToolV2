using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCardComponent : MonoBehaviour
{
    public GameObject baseObj;



    public void InstantiateBaseObj()
    {
        var obj = Instantiate(baseObj, transform);
    }
}
