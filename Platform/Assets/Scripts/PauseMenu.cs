using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public static bool gameispaused = false;
   public GameObject pauseMenuUI;
   public GameObject RestartMenuUI;
    public Transform player; 
  private float fallThreshold = -30f;
    
    private void Start()
    {
            pauseMenuUI.SetActive(false);
            RestartMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (Hero.Instance.lives <= 0 || player.position.y < fallThreshold)
        {
            Gameover();
        }

    }
    public void Gameover()
    {
        RestartMenuUI.SetActive(true);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Resume()
    {
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            gameispaused = false;
        }
        
    }

    public void Pause()
    {
        if (RestartMenuUI.activeSelf)  
        {
            return; 
        }
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            gameispaused = true;
        }
    }
}
