using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timer = 0f;
    public GameObject prefab;
    public int spawnCounter = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer = timer - Time.deltaTime;
        }

        if (timer <=0)
        {
            spawnCounter = spawnCounter - 1;
            Instantiate(prefab, new Vector2(gameObject.transform.position.x, Random.Range(-0.677f, 0.346f)),Quaternion.identity);
            timer = 2.0f;
        }

    }
}
