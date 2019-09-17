using System;
using UnityEngine;

public class ScreenShotButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        ScreenCapture.CaptureScreenshot(DateTime.Now.Ticks+"ss.png");
    }
}
