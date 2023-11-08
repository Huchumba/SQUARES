using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZAWARUDO : MonoBehaviour
{
    public GameObject panel;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pause();
        }
    }
    public void pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void play()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
