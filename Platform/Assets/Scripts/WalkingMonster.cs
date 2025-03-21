using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingMonster : Entity
{
    
    private Vector3 direction;
    private SpriteRenderer sprite;
    private LayerMask coinLayer;
    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        coinLayer = LayerMask.GetMask("Coin");
    }
    private void Start()
    {
        direction = transform.right;
    }
    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * direction.x * 0.7f, 0.1f, ~coinLayer);

        if (colliders.Length > 0) direction *= -1f;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, Time.deltaTime);
        sprite.flipX = direction.x > 0.0f;

    }
    private void Update()
    {
        Move();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
        }
    }
}