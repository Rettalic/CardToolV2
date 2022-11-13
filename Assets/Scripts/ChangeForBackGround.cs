using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeForBackGround : MonoBehaviour
{
    public GameObject obj;
    public void GoInfront()
    {
        int i = obj.transform.GetSiblingIndex();
        obj.transform.SetSiblingIndex(i + 1);
    }

    public void GoToBack()
    {
        int i = obj.transform.GetSiblingIndex();
        obj.transform.SetSiblingIndex(i - 1);
    }
}
