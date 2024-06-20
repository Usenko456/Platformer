using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip Background;
    private bool isPaused=true;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
        isPaused = PauseMenu.gameispaused;
    }

    private void Update()
    {
        if (PauseMenu.gameispaused && !isPaused)
        {
            musicSource.Pause();
            isPaused = true;
        }
        else if (!PauseMenu.gameispaused && isPaused)
        {
            musicSource.Play();
            isPaused = false;
        }
    }
}




