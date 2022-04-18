using System.Collections;
using UnityEngine;

public class EnemyTankView : MonoBehaviour
{
    public MeshRenderer[] childs;
    EnemyTankController enemyTankController;
    public ShellSpawner shellSpawner;
    public LayerMask playerMask;

    void Start() {
        StartCoroutine(ScanCoroutine());
        StartCoroutine(FireCoroutine());
    }

    void FixedUpdate() {
        if(enemyTankController.isplayerVisible)
            transform.LookAt(enemyTankController.playerTransform);
    }

    public void SetTankController(EnemyTankController _enemyTankController){
        enemyTankController = _enemyTankController;
    }

    public void ChangeColor(Material color){
        for(int i = 0; i < childs.Length; i++)
            childs[i].material = color;
    }

    IEnumerator ScanCoroutine()
    {
        while(true){
            yield return new WaitForSeconds(0.2f);
            enemyTankController.ScanPlayer(transform, playerMask);
        }
    }

    IEnumerator FireCoroutine(){
        while(true){
            if(enemyTankController.isplayerVisible)
                shellSpawner.CreateShell();
            yield return new WaitForSeconds(enemyTankController.enemyTankModel.fireCooldown);
        }
    }
}
