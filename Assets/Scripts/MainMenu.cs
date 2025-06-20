using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void ukoncit()
    {
        Application.Quit();
    }

    public void startgame()
    {
        Application.LoadLevel("Game");
    }
}

