using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * A MonoBehavior with a function for loading a specified scene.
 **/
public class RestartBehavior : MonoBehaviour
{
    public void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
