using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankModel
{
    private EnemyTankController enemytankController;
    public Material color;

    public EnemyTankModel(Material _color){
        color = _color;
    } 

    public void SetTankController(EnemyTankController _enemytankController){
        enemytankController = _enemytankController;
    }
}
