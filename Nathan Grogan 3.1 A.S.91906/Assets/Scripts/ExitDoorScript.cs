using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ExitDoorScript : MonoBehaviour
{
    public SpeedrunTimer timerScript;
    private bool hasWon;
    public Image TimerBackground;
    public Sprite wonBG;
    
    public TextMeshProUGUI date;
    public Image victoryBG;
    private string formattedDate;
    public TextMeshProUGUI VictoryText1;
    public TextMeshProUGUI VictoryText2;
    public TextMeshProUGUI VictoryText3;
    public TextMeshProUGUI VictoryText4;
    public TextMeshProUGUI VictoryText5;
    public TextMeshProUGUI SpeedrunnerSubtitle;
    public TMP_InputField SpeedrunnerName;
    public GameObject RestartButton;
    public GameObject TitleButton;
    public GameObject ScreenshotButton;
    
    private void Start() 
    {
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
        victoryBG.gameObject.SetActive(true);
        System.DateTime currentDate = System.DateTime.Now;
        string formattedDate = currentDate.ToString("MM/dd/yyyy");
        date.SetText(formattedDate);
        UIVisible(); 
    }

    public bool HasWonGame()
    {
        return hasWon;
    }
    private void UIVisible()
    {
        VictoryText1.gameObject.SetActive(true);
        VictoryText2.gameObject.SetActive(true);
        VictoryText3.gameObject.SetActive(true);
        VictoryText4.gameObject.SetActive(true);
        VictoryText5.gameObject.SetActive(true);
        date.gameObject.SetActive(true);
        SpeedrunnerSubtitle.gameObject.SetActive(true);
        SpeedrunnerName.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
        TitleButton.gameObject.SetActive(true);
        ScreenshotButton.gameObject.SetActive(true);

    }
}
  