using UnityEngine;

public class Corn : MonoBehaviour
{
    public int health = 10;
    public GameObject gameovertext;
    
    public void TakeDamage()
    {
        health = health - 1;

        if (health <= 0)
        {
            gameovertext.SetActive(true);
        }

    }

}
