﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PH_SpawnPoint : MonoBehaviour
{
    public Transform StartPoint;
    public Transform EndPoint;
    public void SpawnEnemy(BaseEnemy enemy)
    {
        Debug.Log("Spawned: " + enemy.ID);
    }
}