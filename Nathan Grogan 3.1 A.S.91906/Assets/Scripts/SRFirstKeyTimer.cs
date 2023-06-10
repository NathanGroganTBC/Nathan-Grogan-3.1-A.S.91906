using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SRFirstKeyTimer : MonoBehaviour
{
    public SpeedrunTimer timerScript;
    public TextMeshProUGUI TimerText;
    public Image TimerBackground;
    public Key1Script key1;
    public Key2Script key2;
    public Sprite key2BG;

    private bool isActive;

    private void Start()
    {
        isActive = false;
    }

    private void Update()
    {
        if (key1 != null && key1.IsKeyCollected() && !key2.IsKeyCollected())
        {
            TimerText.gameObject.SetActive(true);
            isActive = true;
        }
        if (isActive)
        {

            // Get the current time from the TimerScript
            float currentTime = timerScript.GetCurrentTime();
    
            // Calculate minutes and seconds
            int minutes = (int)(currentTime / 60);
            int seconds = (int)(currentTime % 60);
            if (key2 != null && key2.IsKeyCollected())
            {
                StopStartTimer();
                TimerBackground.sprite = key2BG;
                
            }
    
            // Update the UI text element
            TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }


    public void StopStartTimer()
    {
        isActive = false;
    }

    
}
