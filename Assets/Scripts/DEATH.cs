using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DEATH : MonoBehaviour
{
    [SerializeField] private PlayerMove bluePlayer;
    [SerializeField] private PlayerMoveRed redPlayer;
    static float redkaboom = 50;
    static float bluekaboom = 50;
    public static float redspeed = 3;
    public static float bluespeed = 3;

    public static int bl;
    public static int rdd;

    int r;

    [SerializeField] Text Blue;
    [SerializeField] Text Red;
    private void Start()
    {
        Blue.text = "Blue: " + bl;
        Red.text = "Red: " + rdd;
        redPlayer.kaboom = redkaboom;
        bluePlayer.kaboom = bluekaboom;
        redPlayer.speed = redspeed;
        bluePlayer.speed = bluespeed;
        r = PlayerPrefs.GetInt("rounds");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerRed")
        {
            Destroy(gameObject);
            bl++;
            if (bl > r-1)
            {
                rdd = 0;
                bl = 0;
                redkaboom = 50;
                bluekaboom = 50;
                redspeed = 3;
                bluespeed = 3;

                SceneManager.LoadScene("BlueWin");
            }
            else
            {
                Bonus_1();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }

        else if(collision.gameObject.tag == "PlayerBlue")
        {
            Destroy(gameObject);
            rdd++;
            if (rdd > r-1)
            {
                rdd = 0;
                bl = 0;
                redkaboom = 50;
                bluekaboom = 50;
                redspeed = 3;
                bluespeed = 3;

                SceneManager.LoadScene("RedWin");
            }
            else
            {
                Bonus_1();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
           
        }

        else if (collision.gameObject.tag == "ground")
        {
            Destroy(collision.gameObject);
        }
    }

    void Bonus_1()
    {
        if (PlayerPrefs.GetInt("toggle2Key") == 1)
        {
            if (bl > rdd)
            {
                if (bl - rdd == 2)
                {
                    bluekaboom = 100;
                    redspeed = 3.3f;
                }
                else if (bl - rdd == 4)
                {
                    bluekaboom = 150;
                    redspeed = 3.7f;
                    bluespeed = 2.7f;
                }
                else if (bl - rdd <= 6)
                {
                    bluekaboom = 175;
                    redspeed = 4.2f;
                    bluespeed = 2.4f;
                }
            }
            else if (rdd > bl)
            {
                if (rdd - bl == 2)
                {
                    redkaboom = 100;
                    bluespeed = 3.3f;
                }
                else if (rdd - bl == 4)
                {
                    redkaboom = 150;
                    bluespeed = 3.7f;
                    redspeed = 2.7f;
                }
                else if (rdd - bl == 6)
                {
                    redkaboom = 175;
                    bluespeed = 4.2f;
                    redspeed = 2.4f;
                }
            }
        }
    }
}
