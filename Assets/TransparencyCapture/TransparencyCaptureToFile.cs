using System.Collections;
using UnityEngine;

public class TransparencyCaptureToFile : MonoBehaviour
{
    public zzTransparencyCapture cap;
  
    public IEnumerator capture()
    {
        yield return new WaitForEndOfFrame();
        //After Unity4,you have to do this function after WaitForEndOfFrame in Coroutine
        //Or you will get the error:"ReadPixels was called to read pixels from system frame buffer, while not inside drawing frame"
        cap.captureScreenshot("capture.png");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
           StartCoroutine(capture());
    }

    public void RunCapture()
    {
        StartCoroutine(capture());
    }
}