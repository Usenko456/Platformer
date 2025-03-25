using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : Entity
{
    private void Start()
    {
        lives = 3;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject) 
        {
            Vector2 contactPoint = collision.GetContact(0).point; 
            Vector2 enemyPosition = transform.position;
            float playerBottom = Hero.Instance.transform.position.y - Hero.Instance.GetComponent<Collider2D>().bounds.extents.y;

            if (playerBottom > enemyPosition.y + 0.2f) 
            {
                lives--; 
                Debug.Log("У черв'яка залишилось життів: " + lives);

                if (lives < 1)
                    Die();
            }
            else
            {
                Hero.Instance.GetDamage(); 
            }
        }
    }
}
