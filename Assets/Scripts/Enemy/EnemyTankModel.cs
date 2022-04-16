﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankModel
{
    private EnemyTankController enemytankController;
    public Material color;
    public Transform tankTransform;
    public Transform enemyTankTransform;
    bool shellReloadRequired = false;

    public EnemyTankModel(Material _color){
        color = _color;
    } 

    public void SetTankController(EnemyTankController _enemytankController){
        enemytankController = _enemytankController;
    }

    public void SetTankTransform(Transform _tankTransform, Transform _enemyTankTransform){
        tankTransform = _tankTransform;
        enemyTankTransform = _enemyTankTransform;
    }

    public bool ReadyToFire(){
        if(shellReloadRequired)
            return false;
        shellReloadRequired = true;
        return true;
    }
}
