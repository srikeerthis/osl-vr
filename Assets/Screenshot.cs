using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    // Capture frames as a screenshot sequence. Images are
    // stored as PNG files in a folder 
    // If the folder exists we will append numbers to create an empty folder.
    string folder = "ScreenshotFolder";
    int frameRate = 25;

    // Start is called before the first frame update
    void Start()
    {
        // Set the playback framerate (real time will not relate to game time after this).
        Time.captureFramerate = frameRate;
        // Create the folder
        System.IO.Directory.CreateDirectory(folder);
    }

    // Update is called once per frame
    void Update()
    {
        //path where image is stored                 
        string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount );
        //screenshot is taken
        ScreenCapture.CaptureScreenshot(name);   
    }
}
