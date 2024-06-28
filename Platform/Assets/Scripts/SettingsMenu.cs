using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenuUI;
    void Start()
    {
        settingsMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settingsMenuUI.SetActive(false);
        }
    }
    public void settingsbuttonpressed()
    {
        settingsMenuUI.SetActive(true);     
    }
    public void exitsettingsbuttonpressed()
    {
        settingsMenuUI.SetActive(false);
    }
}
