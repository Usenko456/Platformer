
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenegerScript : MonoBehaviour
{
    public static void LoadScene(string sceneName) 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
    public static void Loadlastlevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level"+ ButtonActivasion.numberofunlockedlevels);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
