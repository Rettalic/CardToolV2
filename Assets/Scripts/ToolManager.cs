using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum toolState
{
    mouseMove = 0,
    buttonMove = 1,
    changeImage = 2,
    helpMenu = 3
}

public class ToolManager : MonoBehaviour
{
   public toolState toolState;

    public FileManager fMan;
    public ChangeAsset cAsset;

    public ChangePos cPos;
    
    public TransparencyCaptureToFile capToFile;
    public zzTransparencyCapture capture;

      


    // Update is called once per frame
    void Update()
    {
        switch(toolState) 
        {
            case toolState.mouseMove:

                break;
            case toolState.buttonMove:

                break;
            case toolState.changeImage:

                break;
            case toolState.helpMenu:

                break;
        }
    }
}
