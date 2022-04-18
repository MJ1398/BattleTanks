using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank{
        public float movementSpeed;
        public float rotatationSpeed;
        public TankTypes tankType;
        public Material color;
        public int health;
    }
    public List<Tank> tankList;
    public TankView tankView;

    public void CreateTank(TankTypes tankType, GameUI gameUI, GameOverUI gameOverUI){
        if(tankType == TankTypes.BlueTank){
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotatationSpeed, tankList[1].tankType, tankList[1].color, tankList[1].health);
            TankController tankController = new TankController(tankModel, tankView, gameUI, gameOverUI);
        }
        else if(tankType == TankTypes.GreenTank){
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotatationSpeed, tankList[0].tankType, tankList[0].color, tankList[0].health);
            TankController tankController = new TankController(tankModel, tankView, gameUI, gameOverUI);
        }
        else if(tankType == TankTypes.RedTank){
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotatationSpeed, tankList[2].tankType, tankList[2].color, tankList[2].health);
            TankController tankController = new TankController(tankModel, tankView, gameUI, gameOverUI);
        }
    }
}
