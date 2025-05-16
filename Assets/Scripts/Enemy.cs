using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject border;
    public Animator animator;

    public float timer = 0f;





    public void TakeDamage()
    {
        health = health - 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(timer > 0)
        {
            timer = timer - Time.deltaTime;
        }
        
        if (transform.position.x > border.transform.position.x)
        {
            transform.position = transform.position + new Vector3(-1.0f, 0.0f, 0.0f) * 0.7f * Time.deltaTime;
        } else
        {
            animator.SetBool("isMoving", false);
        }



        if (timer <= 0)
        {
            timer = 1.0f;
            
            if(transform.position.x <= border.transform.position.x)
            {
                Attack();
            }
            
        }



    }

    public void Attack()
    {
        border.GetComponent<Corn>().TakeDamage();
    }
}
