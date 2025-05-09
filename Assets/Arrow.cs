using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * 3.0f * Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().TakeDamage();
        }

        Destroy(gameObject);
    }

}
