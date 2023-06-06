using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] Button _restartButton;
    [SerializeField] Button _titleButton;

    // Start is called before the first frame update
    void Start()
    {
        _restartButton.onClick.AddListener(NewGame);
        _titleButton.onClick.AddListener(OpenTitleScene);

    }

    private void NewGame()
    {
        SceneManager.LoadScene(0);

    }
        private void OpenTitleScene()
    {
        SceneManager.LoadScene(2);

    }
}
