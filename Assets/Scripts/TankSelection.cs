using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    public EnemyTankSpawner enemyTankSpawner;

    public void BlueTankSelected(){
        tankSpawner.CreateTank(TankTypes.BlueTank);
        enemyTankSpawner.CreateTank();
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected(){
        tankSpawner.CreateTank(TankTypes.GreenTank);
        enemyTankSpawner.CreateTank();
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected(){
        tankSpawner.CreateTank(TankTypes.RedTank);
        enemyTankSpawner.CreateTank();
        this.gameObject.SetActive(false);
    }
}
