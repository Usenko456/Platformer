using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer; // Назви змінних з малої літери
    [SerializeField] private Slider musicVolumeSlider;

    private const string MusicVolumeKey = "MusicVolume"; // Ключ для PlayerPrefs

    private void Start()
    {
        // Завантажуємо збережений рівень гучності або встановлюємо значення за замовчуванням (0.75f)
        float savedVolume = PlayerPrefs.GetFloat(MusicVolumeKey, 0.75f);
        musicVolumeSlider.value = savedVolume; // Встановлюємо значення слайдера
        SetMusicVolume(savedVolume); // Оновлюємо гучність у мікшері
    }

    public void SetMusicVolume()
    {
        float volume = musicVolumeSlider.value;
        SetMusicVolume(volume);
    }

    private void SetMusicVolume(float volume)
    {
        // Застосовуємо рівень гучності до AudioMixer
        audioMixer.SetFloat("music", Mathf.Log10(volume) * 20);

        // Зберігаємо рівень гучності в PlayerPrefs
        PlayerPrefs.SetFloat(MusicVolumeKey, volume);
    }
}
