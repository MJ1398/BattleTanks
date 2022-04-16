﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankSpawner : MonoBehaviour
{
    public Material color;
    public EnemyTankView enemyTankView;

    public void CreateTank(){
        EnemyTankModel enemyTankModel = new EnemyTankModel(color);
        EnemyTankController tankController = new EnemyTankController(enemyTankModel, enemyTankView, transform);
    }
}
