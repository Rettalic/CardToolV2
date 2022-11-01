using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangePos : MonoBehaviour
{
    public InputField field;
    public Vector2 currentPos;
    public GameObject asset;
    public Slider sliderX;
    public Slider sliderY;
    public Slider sliderR;
    public Slider sliderS;

    public Camera cam;

    public int maxValX;
    public int minValX;

    public int maxValY;
    public int minValY;

    public int maxValR;
    public int minValR;

    public int maxValS;
    public int minValS;


    private void Start()
    {
        currentPos = new Vector2();
        
        sliderX.onValueChanged.AddListener((v) => field.text = v.ToString("0.0"));
        sliderX.maxValue = maxValX;
        sliderX.minValue = minValX;

        sliderY.onValueChanged.AddListener((v) => field.text = v.ToString("0.0"));
        sliderY.maxValue = maxValY;
        sliderY.minValue = minValY;

        sliderR.onValueChanged.AddListener((v) => field.text = v.ToString("0.0"));
        sliderR.maxValue = maxValR;
        sliderR.minValue = minValR;

        sliderS.onValueChanged.AddListener((v) => field.text = v.ToString("0.0"));
        sliderS.maxValue = maxValS;
        sliderS.minValue = minValS;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) StoreField();
        currentPos.x = sliderX.value;
        currentPos.y = sliderY.value;
        asset.transform.position = currentPos;

        //asset.transform.localScale.x = sliderS.value;

        if (Input.GetMouseButton(0) && Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            Debug.Log('1');
            
            RaycastHit2D hit = Physics2D.Raycast(cam.transform.position, transform.TransformDirection(Vector2.up), 1f);
            if (hit)
            {
                Debug.Log(hit);
                asset = hit.transform.gameObject;
            }
        }
    }

    public void StoreField()
    {
        sliderX.value = float.Parse(field.text);
    }

    public void SetObj()
    {

    }
}
