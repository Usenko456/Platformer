using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public int coinnumber;
    public int lives;
    public virtual void GetDamage()
    {
        lives--;
        Debug.Log(lives);
        if (lives < 1)
            Die();
        if (lives <= 0)
        {
            Die();
        }
    }
    
    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}