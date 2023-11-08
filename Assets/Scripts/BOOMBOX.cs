using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BOOMBOX : MonoBehaviour
{
    public GameObject BOOMBOXP;
    public AudioSource audioSource;
    public GameObject[] objsll;

    void Awake()
    {

        objsll = GameObject.FindGameObjectsWithTag("BOOMBOX");
        if (objsll.Length == 0)
        {
            BOOMBOXP = Instantiate(BOOMBOXP);
            BOOMBOXP.name = "BOOMBOXP1";
            DontDestroyOnLoad(BOOMBOXP.gameObject);
        }
        else
        {
            BOOMBOXP = GameObject.Find("BOOMBOXP1");
        }
    }

    private void Start()
    {
        audioSource = BOOMBOXP.GetComponent<AudioSource>();
    }


}
