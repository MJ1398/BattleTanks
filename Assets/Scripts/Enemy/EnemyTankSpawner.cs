using UnityEngine;

public class EnemyTankSpawner : MonoBehaviour
{
    public Material color;
    public float fireCooldown;
    public float scanDistance;
    public EnemyTankView enemyTankView;

    public void CreateTank(){
        EnemyTankModel enemyTankModel = new EnemyTankModel(color, fireCooldown, scanDistance);
        EnemyTankController tankController = new EnemyTankController(enemyTankModel, enemyTankView, transform);
    }
}
