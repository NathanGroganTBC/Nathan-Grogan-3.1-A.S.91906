using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _startButton;
    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener(StartNewGame);
    }

    private void StartNewGame()
    {
        SceneManager.LoadScene(1);

    }
}
