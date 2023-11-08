using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class All_settings : MonoBehaviour
{
    public Toggle toggle;
    public Toggle toggle2;
    public Slider sld;

    int rs;
    void Start()
    {
        sld.value = 10;
        PlayerPrefs.SetInt("rounds", Convert.ToInt32(sld.value));
        toggle.isOn = PlayerPrefs.GetInt("toggleKey") == 1;
        toggle.isOn = PlayerPrefs.GetInt("toggle2Key") == 1;
    }

    public void toggleTrigger()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("toggleKey", 1);
        }
        else
        {
            PlayerPrefs.SetInt("toggleKey", 0);
        }

        if (toggle2.isOn)
        {
            PlayerPrefs.SetInt("toggle2Key", 1);
        }
        else
        {
            PlayerPrefs.SetInt("toggle2Key", 0);
        }
    }
    public void Rounds()
    {
        PlayerPrefs.SetInt("rounds", Convert.ToInt32(sld.value));
    }
}
