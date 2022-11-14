using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangePos : MonoBehaviour
{
    public InputField fieldX;
    public InputField fieldY;
    public InputField fieldR;
    public InputField fieldS;

    public Vector2 currentPos;
    public GameObject asset;
    public Camera cam;

    public Slider sliderX;
    public Slider sliderY;
    public Slider sliderR;
    public Slider sliderS;


    public int maxValX;
    public int minValX;

    public int maxValY;
    public int minValY;

    public int maxValR;
    public int minValR;

    public float maxValS;
    public float minValS;

    public TextMeshProUGUI X;
    public TextMeshProUGUI Y;
    public TextMeshProUGUI R;
    public TextMeshProUGUI S;

    private void Start()
    {
        currentPos = new Vector2();
        
        sliderX.onValueChanged.AddListener((v) => fieldX.text = v.ToString("0.0"));
        sliderX.maxValue = maxValX;
        sliderX.minValue = minValX;

        sliderY.onValueChanged.AddListener((v) => fieldY.text = v.ToString("0.0"));
        sliderY.maxValue = maxValY;
        sliderY.minValue = minValY;

        sliderR.onValueChanged.AddListener((v) => fieldR.text = v.ToString("0.0"));
        sliderR.maxValue = maxValR;
        sliderR.minValue = minValR;

        sliderS.onValueChanged.AddListener((v) => fieldS.text = v.ToString("0.0"));
        sliderS.maxValue = maxValS;
        sliderS.minValue = minValS;
        sliderS.value = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) StoreField();
        currentPos.x = sliderX.value;
        currentPos.y = sliderY.value;
        asset.transform.rotation = Quaternion.Euler(0, 0, sliderR.value);
        asset.transform.localScale = new Vector3(sliderS.value, sliderS.value, 1);
        asset.transform.position = currentPos;

        X.text = "Pos X: " + asset.transform.position.x.ToString("0.0");
        Y.text = "Pos Y: " + asset.transform.position.y.ToString("0.0");
        R.text = "Rotation: " + sliderR.value.ToString("0.0");
        S.text = "Scale: " + asset.transform.localScale.x.ToString("0.0");
    }

    public void StoreField()
    {
        sliderX.value = float.Parse(fieldX.text);
        sliderY.value = float.Parse(fieldY.text);
        sliderR.value = float.Parse(fieldR.text);
        sliderS.value = float.Parse(fieldS.text);
    }
}
