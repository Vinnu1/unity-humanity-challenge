using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Floor _floor;
    private Rigidbody2D _rigid;
    private float _speed = 3f;
    private float _jumpForce = 7f;
    private Animator _anim;
    private bool _isGrounded = false;
    private SpriteRenderer _playerSprite;


    // Start is called before the first frame update
    void Start()
    {
        _floor = FindObjectOfType(typeof(Floor)) as Floor;
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
        _playerSprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        bool upKey = Input.GetKeyDown("up");
        bool downKey = Input.GetKeyDown("down");
        float move = Input.GetAxisRaw("Horizontal");
        bool isRunning;
        if(move == 0)
        {
            isRunning = false;
        }
        else
        {
            isRunning = true;
        }
        if (move > 0)
        {
            Flip(true);
        }
        else if (move < 0)
        {
            Flip(false);
        }

        _rigid.velocity = new Vector2(move * _speed, _rigid.velocity.y);

        _anim.SetBool("isRunning", isRunning);

        if (downKey)
        {
            _floor.DisableCollider();
        }

        if (upKey && _isGrounded)
        {
            StartCoroutine(SetFloorCollision());
            _rigid.velocity = new Vector2(_rigid.velocity.x, _jumpForce);
        }
    }

    void Flip(bool FaceRight)
    {
        if (FaceRight == true)
        {
            _playerSprite.flipX = false;
            
        }
        else if (FaceRight == false)
        {
            _playerSprite.flipX = true;
            
            }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LowerLayer"))
        {
            _isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LowerLayer"))
        {
            _isGrounded = false;
        }
    }

    IEnumerator SetFloorCollision()
    {
        yield return new WaitForSeconds(1f);
        _floor.EnableCollider();
    }

}