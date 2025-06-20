using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Corn corn;
    public GameRules gamerules;
    public Text health_text;
    public Text level_text;
    public Text score_text;
    public GameObject update_window;
    public int damage_factor = 1;
    public GameObject score_alert;
    
    // Start is called before the first frame update
    void Start()
    {
        update_window.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        health_text.text = corn.health.ToString();
        level_text.text = gamerules.level.ToString();
        score_text.text = gamerules.score.ToString();

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            update_window.SetActive(true);
        }



    }

    public void upgrade_damage_factor()
    {
        if (gamerules.score >= 100)
        {
            damage_factor = damage_factor + 1;
            gamerules.score = gamerules.score - 100;    
        } else {
            score_alert.SetActive(true);          
        }
        
    }

    public void upgrade_health()
    {
        if (gamerules.score >= 100)
        {
            corn.health = corn.health + 1;
            gamerules.score = gamerules.score - 100;    
        } else {
            score_alert.SetActive(true);
        }
    }

    public void remove_update_window()
    {
        update_window.SetActive(false);
    }

    public void remove_score_alert()
    {
        score_alert.SetActive(false);
    }

    public void return_to_menu()
    {
        Application.LoadLevel("MainMenu");
    }
}
