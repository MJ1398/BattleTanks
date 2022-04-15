using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankController
{
    private EnemyTankModel enemyTankModel;
    private EnemyTankView enemyTankView;
    private Rigidbody rb;

    public EnemyTankController(EnemyTankModel _enemyTankModel, EnemyTankView _enemyTankView, Transform transform){
        enemyTankModel = _enemyTankModel;
        enemyTankView = GameObject.Instantiate<EnemyTankView>(_enemyTankView, transform.position, Quaternion.identity);
        rb = enemyTankView.GetRigidbody();
        enemyTankModel.SetTankController(this);
        enemyTankView.SetTankController(this);
        enemyTankView.ChangeColor(enemyTankModel.color);
    }
}
