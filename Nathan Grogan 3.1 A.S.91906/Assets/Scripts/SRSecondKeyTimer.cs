using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SRSecondKeyTimer : MonoBehaviour
{
    public SpeedrunTimer timerScript;
    public TextMeshProUGUI TimerText;
    public Key2Script key2;
    public ExitDoorScript won;
    public Image TimerBackground;
    public Sprite exitBG;

    private bool isActive;

    private void Start()
    {
        isActive = false;
    }

    private void Update()
    {
        if (key2 != null && key2.IsKeyCollected())
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
            if (!won.HasWonGame())
            {
                StopStartTimer();
                TimerBackground.sprite = exitBG;
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
