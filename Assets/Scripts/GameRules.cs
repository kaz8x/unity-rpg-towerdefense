using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    public int level = 1;
    public bool finished = false;
    public Spawner spawner;
    public Corn corn;
    public GameObject gameovertext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(finished == false)
        {
            if(spawner.spawnCounter <=0)
            {
                print("Victory");
                level = level + 1;
                print(level);
                spawner.spawnCounter = 10 + 5*level;
            }
        }

        if(corn.health <= 0)
        {
            gameovertext.SetActive(true);
            finished = true;
        }
    }
}
