using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankModel
{
    private EnemyTankController enemytankController;
    public Material color;
    public float fireCooldown;
    public float scanDistance;

    public EnemyTankModel(Material _color, float _fireCooldown, float _scanDistance){
        color = _color;
        fireCooldown = _fireCooldown;
        scanDistance = _scanDistance;
    } 

    public void SetTankController(EnemyTankController _enemytankController){
        enemytankController = _enemytankController;
    }

}
