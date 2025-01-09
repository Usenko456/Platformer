using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer; 
    [SerializeField] private Slider musicVolumeSlider;
    private const string MusicVolumeKey = "MusicVolume"; 
    private void Start()
    {     
        float savedVolume = PlayerPrefs.GetFloat(MusicVolumeKey, 0.75f);
        musicVolumeSlider.value = savedVolume; 
        SetMusicVolume(savedVolume); 
    }
    public void SetMusicVolume()
    {
        float volume = musicVolumeSlider.value;
        SetMusicVolume(volume);
    }
    private void SetMusicVolume(float volume)
    {   
        audioMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat(MusicVolumeKey, volume);
    }
}
