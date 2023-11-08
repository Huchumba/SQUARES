using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using System;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Sprite[] playersBlue;
    public float kaboom;
    public float jumpPower;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private SpriteRenderer spriteRenderer;
    
    public Rigidbody2D rb2;
    public ParticleSystem ps;

    Rigidbody2D rb;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = playersBlue[PlayerPrefs.GetInt("BluePlayerSkin")];
        }
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
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

        if (Input.GetKey(KeyCode.RightArrow))
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

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector2(0, (-jumpPower * 0.005f)), ForceMode2D.Impulse);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerRed")
        {
            ps.Play();
            if (Math.Abs(rb.velocity.y) + Math.Abs(rb.velocity.x) > Math.Abs(rb2.velocity.y) + Math.Abs(rb2.velocity.x))
            {
                rb.AddForce(-rb.velocity * kaboom * 0.5f);
            }
            else
            {
                rb.AddForce(rb2.velocity * kaboom);
                if (kaboom < 400 && PlayerPrefs.GetInt("toggleKey") == 1)
                {
                    kaboom += 10;
                }
            }
        }
    }
}
