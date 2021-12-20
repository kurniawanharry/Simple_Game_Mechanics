﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    // Start is called before the first frame update
    public int level;
    public int health;
    public float[] position;

    public PlayerData (PlayerOne player)
    {
        level = player.level;
        health = player.health;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
