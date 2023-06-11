using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScreenshot : MonoBehaviour
{
    [SerializeField] Button _screenshotButton;
    public string screenshotPath = "Screenshots";

    // Start is called before the first frame update
    void Start()
    {
        _screenshotButton.onClick.AddListener(Screenshot);
    }

    private void Screenshot()
    {
        CaptureAndSaveScreenshot();
    }

    private void CaptureAndSaveScreenshot()
    {
        // Create the directory if it doesn't exist
        System.IO.Directory.CreateDirectory(screenshotPath);

        // Capture a screenshot
        string screenshotName = $"{screenshotPath}/Screenshot_{System.DateTime.Now:yyyyMMddHHmmss}.png";
        ScreenCapture.CaptureScreenshot(screenshotName);

        Debug.Log($"Screenshot saved: {screenshotName}");
    }

}
