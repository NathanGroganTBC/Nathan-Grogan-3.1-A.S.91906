
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedrunTimer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI millisecondsText;

    private float elapsedTime;
    private bool isRunning;

    private void Start()
    {
        ResetTimer();
        StartTimer();
    }

    private void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;

            // Calculate minutes, seconds, and milliseconds
            int minutes = (int)(elapsedTime / 60);
            int seconds = (int)(elapsedTime % 60);
            int milliseconds = (int)((elapsedTime * 1000) % 1000);

            // Update the UI text elements
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            millisecondsText.text = string.Format(".{0:00}", milliseconds / 10); // Display 2-digit milliseconds
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public float GetCurrentTime()
    {
        return elapsedTime;
    }

    public void ResetTimer()
    {
        elapsedTime = 0f;
        timeText.text = "00:00";
        millisecondsText.text = "000";
    }
}
