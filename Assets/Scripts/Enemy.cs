using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    private GameObject border;
    public Animator animator;
    private GameObject kamera;
    private GameRules level_script;
    private float speed;


    public float timer = 0f;


    void Start()
    {
        border = GameObject.Find("FieldBorder");
        kamera = GameObject.Find("Main Camera");
        level_script = kamera.GetComponent<GameRules>();

    }


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
        speed = 1.0f * 0.2f * level_script.level;
        if(timer > 0)
        {
            timer = timer - Time.deltaTime;
        }
        
        if (transform.position.x > border.transform.position.x)
        {
            transform.position = transform.position + new Vector3(-1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;
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
