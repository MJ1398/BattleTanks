using System.Collections;
using UnityEngine;

public class EnemyTankView : MonoBehaviour
{
    public MeshRenderer[] childs;
    EnemyTankController enemyTankController;
    public ShellSpawner shellSpawner;
    public LayerMask playerMask;
    Transform playerTransform;

    void Start() {
        enemyTankController.isAlive = true;
        StartCoroutine(enemyTankController.ScanCoroutine());
        StartCoroutine(enemyTankController.FireCoroutine());
    }

    void FixedUpdate() {
        if(enemyTankController.isplayerVisible)
            transform.LookAt(playerTransform);
    }

    public void SetTankController(EnemyTankController _enemyTankController){
        enemyTankController = _enemyTankController;
    }

    public void ChangeColor(Material color){
        for(int i = 0; i < childs.Length; i++)
            childs[i].material = color;
    }

    public void ScanPlayer(){
        Collider[] collider = Physics.OverlapSphere(transform.position, enemyTankController.enemyTankModel.scanDistance, playerMask);
        if(collider.Length > 0){
            playerTransform = collider[0].transform;
            enemyTankController.isplayerVisible = true;
        }
        else
            enemyTankController.isplayerVisible = false;
    }
}
