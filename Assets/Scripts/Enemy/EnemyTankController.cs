using System.Collections;
using UnityEngine;

public class EnemyTankController
{
    public EnemyTankModel enemyTankModel;
    private EnemyTankView enemyTankView;
    public bool isplayerVisible;
    public bool isAlive;

    public EnemyTankController(EnemyTankModel _enemyTankModel, EnemyTankView _enemyTankView, Transform transform){
        enemyTankModel = _enemyTankModel;
        enemyTankView = GameObject.Instantiate<EnemyTankView>(_enemyTankView, transform.position, transform.rotation);
        enemyTankModel.SetTankController(this);
        enemyTankView.SetTankController(this);
        enemyTankView.ChangeColor(enemyTankModel.color);
    }

    public IEnumerator ScanCoroutine()
    {
        while(isAlive){
            yield return new WaitForSeconds(0.2f);
            enemyTankView.ScanPlayer();
        }
    }

    public IEnumerator FireCoroutine(){
        while(isAlive){
            if(isplayerVisible)
                enemyTankView.shellSpawner.CreateShell();
            yield return new WaitForSeconds(enemyTankModel.fireCooldown);
        }
    }
}
