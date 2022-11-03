using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAsset : MonoBehaviour
{
    public List<GameObject> indexButtons;
    public List<GameObject> pickButtons;

    public void EnableIndexButtons()
    {
        for (int i = 0; i < pickButtons.Count; i++)
        {
            pickButtons[i].SetActive(false);
            indexButtons[i].SetActive(true);
        }
    }

    public void EnablePickButtons()
    {
        for (int i = 0; i < pickButtons.Count; i++)
        {
            pickButtons[i].SetActive(true);
            indexButtons[i].SetActive(false);
        }
    }
}
