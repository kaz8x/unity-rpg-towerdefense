using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health = 5;
    private GameObject border;
    public Animator animator;
    private GameObject kamera;
    private GameRules level_script;
    private float speed;
    private NewBehaviourScript UI;


    public float timer = 0f;


    void Start()
    {
        border = GameObject.Find("FieldBorder");
        kamera = GameObject.Find("Main Camera");
        UI = GameObject.Find("Canvas").GetComponent<NewBehaviourScript>();
        level_script = kamera.GetComponent<GameRules>();

    }


    public void TakeDamage()
    {
        health = health - UI.damage_factor;
        if (health <= 0)
        {
            level_script.score = level_script.score + 1;
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
