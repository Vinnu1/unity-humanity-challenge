using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC : MonoBehaviour
{
    protected Vector3 currentTarget;
    protected SpriteRenderer sprite;
    protected Player player;
    public GameObject dialogueBox;
    

    public virtual void Init()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void Start()
    {
        Init();
    }

    public virtual void Update()
    {
            Movement();
    }

    public virtual void Movement()
    {
        Vector3 direction = player.transform.localPosition - transform.localPosition;
        if (direction.x > 0 )
        {
            sprite.flipX = false;
        }
        else if (direction.x < 0 )
        {
            sprite.flipX = true;
        }

    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            dialogueBox.SetActive(true);
        }
    }

    public virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            dialogueBox.SetActive(false);
        }
    }


}
