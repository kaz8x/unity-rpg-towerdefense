using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    
    
    public void TakeDamage()
    {
        health = health - 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
