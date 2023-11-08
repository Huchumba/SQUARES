using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class PlayerMoveRed : MonoBehaviour
{
    public Sprite[] playersRed;

    public float speed;

    public float kaboom;
    public float jumpPower;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private CreateMap createMap;

    public Rigidbody2D rb2;
    private SpriteRenderer spriteRenderer;

    Rigidbody2D rb;
    public ParticleSystem ps;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();


        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = playersRed[PlayerPrefs.GetInt("RedPlayerSkin")];
        }
    }

    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (rb.velocity.x > 0)
            {
                rb.AddForce(new Vector2(-speed * 0.16f, 0), ForceMode2D.Impulse);
            }
            else
            {
                rb.AddForce(new Vector2(-speed * 0.08f, 0), ForceMode2D.Impulse);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (rb.velocity.x < 0)
            {
                rb.AddForce(new Vector2(speed * 0.16f, 0), ForceMode2D.Impulse);
            }
            else
            {
                rb.AddForce(new Vector2(speed * 0.08f, 0), ForceMode2D.Impulse);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, (-jumpPower * 0.005f)), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBlue")
        {
            ps.Play();
            if (Math.Abs(rb.velocity.y) + Math.Abs(rb.velocity.x) > Math.Abs(rb2.velocity.y) + Math.Abs(rb2.velocity.x))
            {
                rb.AddForce(-rb.velocity * kaboom * 0.5f);
            }
            else
            {
                rb.AddForce(rb2.velocity * kaboom);
                if(kaboom < 400 && PlayerPrefs.GetInt("toggleKey") == 1)
                {
                    kaboom += 10;
                }
            }
        }
    }
}
