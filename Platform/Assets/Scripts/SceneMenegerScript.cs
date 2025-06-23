
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMenegerScript : MonoBehaviour
{
    void Start()
    {
        Canvas.ForceUpdateCanvases();
        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
    }
    public static void LoadScene(string sceneName) 
    {
        Time.timeScale = 1f;
        PauseMenu.gameispaused = false;
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
