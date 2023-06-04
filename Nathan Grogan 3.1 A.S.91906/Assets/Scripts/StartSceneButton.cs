using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneButton : MonoBehaviour
{
    public string sceneName;

    public void StartSceneTransition()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("clicked");
    }
}
