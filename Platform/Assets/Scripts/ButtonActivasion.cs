﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActivasion : MonoBehaviour
{
    public Button[] buttons;
    
    public Color dimmedTextColor = Color.gray; 
    public Color normalTextColor = Color.white;
    public static int numberofunlockedlevels = 1;
    public void Awake()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < numberofunlockedlevels; i++)
        {
            buttons[i].interactable = true;
        }
    }
    private void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            
            TextMeshPro buttonText = buttons[i].GetComponentInChildren<TextMeshPro>();

            if (buttonText != null)
            {
               
                buttonText.color = buttons[i].interactable ? normalTextColor : dimmedTextColor;
            }
        }
    }
}
