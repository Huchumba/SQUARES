using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour
{
    public void SetBluePlayerSkin(int indexB)
    {
        PlayerPrefs.SetInt("BluePlayerSkin", indexB);
    }

    public void SetRedPlayerSkin(int indexR)
    {
        PlayerPrefs.SetInt("RedPlayerSkin", indexR);
    }
}
