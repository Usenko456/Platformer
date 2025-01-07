using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer AudioMixer;
    [SerializeField] private Slider MusicVolumeSlider;
    public void SetMusicVolume()
    {
        float volume = MusicVolumeSlider.value;
        AudioMixer.SetFloat("music", Mathf.Log10(volume)*20);
    }
}
