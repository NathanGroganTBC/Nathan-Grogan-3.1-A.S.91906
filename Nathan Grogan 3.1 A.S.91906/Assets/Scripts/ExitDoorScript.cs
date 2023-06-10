using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ExitDoorScript : MonoBehaviour
{
    public SpeedrunTimer timerScript;
    private bool hasWon;
    public Image TimerBackground;
    public Sprite wonBG;
    
    
    private void Start() {
        hasWon = false;
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasWon)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        hasWon = true;
        timerScript.StopTimer();
        TimerBackground.sprite = wonBG;
    }

    public bool HasWonGame()
    {
        return hasWon;
    }
}
 