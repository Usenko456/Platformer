using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   public static bool gameispaused = false;
   public GameObject pauseMenuUI;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    public void Pause()
    {
      
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }
}
