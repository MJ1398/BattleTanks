using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankController
{
    private EnemyTankModel enemyTankModel;
    private EnemyTankView enemyTankView;
    private Rigidbody rb;
    private Coroutine coroutine;

    public EnemyTankController(EnemyTankModel _enemyTankModel, EnemyTankView _enemyTankView, Transform transform){
        enemyTankModel = _enemyTankModel;
        enemyTankView = GameObject.Instantiate<EnemyTankView>(_enemyTankView, transform.position, transform.rotation);
        rb = enemyTankView.GetRigidbody();
        enemyTankModel.SetTankController(this);
        enemyTankView.SetTankController(this);
        enemyTankView.ChangeColor(enemyTankModel.color);
        enemyTankModel.SetTankTransform(enemyTankView.GetTankTransform(), enemyTankView.transform);
    }

    public void TrackPlayerLocation(){
        if(Vector3.Distance(enemyTankModel.tankTransform.position, enemyTankModel.enemyTankTransform.position) < 15)
            StartFire();
        else
            Stopfire();
    }

    public void TrackPlayerDirection(){
        if(coroutine != null)
            enemyTankModel.enemyTankTransform.LookAt(enemyTankModel.tankTransform);
    }

    public void StartFire(){
        if(coroutine == null)    
            coroutine = enemyTankView.StartCoroutine(Fire());
    }

    public void Stopfire(){
        if(coroutine != null){
            enemyTankView.StopCoroutine(coroutine);
            coroutine = null;
        }
    }

    IEnumerator Fire(){
        while(true){
            enemyTankView.shellSpawner.CreateShell();
            yield return new WaitForSeconds(2);
        }
        
    }
}
