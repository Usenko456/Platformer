using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenegerScript : MonoBehaviour
{
    public void LoadScene(string sceneName)
        {
        SceneManager.LoadScene(sceneName);
        if (PauseMenu.gameispaused)
        {
            PauseMenu.Resume();
        }
        }
        public void Quitgame()
    {
        Application.Quit();
    }
}
