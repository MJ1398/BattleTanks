using UnityEngine;

public class TankSelection 
{
    public TankSpawner tankSpawner;
    public EnemyTankSpawner enemyTankSpawner;
    public GameUI gameUI;
    public GameOverUI gameOverUI;

    public void BlueTankSelected(){
        tankSpawner.CreateTank(TankTypes.BlueTank, gameUI, gameOverUI);
        enemyTankSpawner.CreateTank();
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected(){
        tankSpawner.CreateTank(TankTypes.GreenTank, gameUI, gameOverUI);
        enemyTankSpawner.CreateTank();
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected(){
        tankSpawner.CreateTank(TankTypes.RedTank, gameUI, gameOverUI);
        enemyTankSpawner.CreateTank();
        this.gameObject.SetActive(false);
    }
}
