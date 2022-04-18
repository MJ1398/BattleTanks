using UnityEngine;

public class EnemyTankController
{
    public EnemyTankModel enemyTankModel;
    private EnemyTankView enemyTankView;
    public bool isplayerVisible;
    public Transform playerTransform;

    public EnemyTankController(EnemyTankModel _enemyTankModel, EnemyTankView _enemyTankView, Transform transform){
        enemyTankModel = _enemyTankModel;
        enemyTankView = GameObject.Instantiate<EnemyTankView>(_enemyTankView, transform.position, transform.rotation);
        enemyTankModel.SetTankController(this);
        enemyTankView.SetTankController(this);
        enemyTankView.ChangeColor(enemyTankModel.color);
    }

    public void ScanPlayer(Transform enemyTransform, LayerMask playerMask){
        Collider[] collider = Physics.OverlapSphere(enemyTransform.position, enemyTankModel.scanDistance, playerMask);
        if(collider.Length > 0){
            playerTransform = collider[0].transform;
            isplayerVisible = true;
        }
        else
            isplayerVisible = false;
    }
}
