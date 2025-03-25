using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
            if(settingsMenuUI != null)
               
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
