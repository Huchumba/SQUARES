using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose : MonoBehaviour
{
    public Sprite[] playersRed;
    public Sprite[] playersBlue;
    public SpriteRenderer spriteRendererRed;
    public SpriteRenderer spriteRendererBlue;

    void Update()
    {
        spriteRendererRed = GetComponent<SpriteRenderer>();
        spriteRendererBlue = GetComponent<SpriteRenderer>();
    }
    public void blue()
    {
        
        spriteRendererBlue.sprite = playersBlue[PlayerPrefs.GetInt("BluePlayerSkin")];
    }
    public void red()
    {
        
        spriteRendererRed.sprite = playersRed[PlayerPrefs.GetInt("RedPlayerSkin")];
    }
}
