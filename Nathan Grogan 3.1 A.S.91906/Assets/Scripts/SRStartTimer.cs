using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SRStartTimer : MonoBehaviour
{
    public SpeedrunTimer timerScript;
    public TextMeshProUGUI startTimerText;
    public Key1Script key1;


    private bool isActive;

    private void Start()
    {
        isActive = true;
    }

    private void Update()
    {
        if (isActive)
        {

            // Get the current time from the TimerScript
            float currentTime = timerScript.GetCurrentTime();

            // Calculate minutes and seconds
            int minutes = (int)(currentTime / 60);
            int seconds = (int)(currentTime % 60);
            if (key1 != null && key1.IsKeyCollected())
            {
                 StopStartTimer();
            }

            // Update the UI text element
            startTimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }


    public void StopStartTimer()
    {
        isActive = false;
    }


    
}
