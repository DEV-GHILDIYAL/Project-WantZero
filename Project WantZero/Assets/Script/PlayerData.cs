using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int score;

    public PlayerData(PlayerController player)
    {
        MainGame mg = new MainGame();
        if (mg.pointsText.text == "0")
        {
            score = player.lowscore;
        }
    }
}
