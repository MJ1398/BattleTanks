using System.Collections;
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
    }
    public List<Tank> tankList;
    public TankView tankView;

    void Start()
    {
        CreateTank();
    }

    private void CreateTank(){
        TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotatationSpeed, 
            tankList[1].tankType, tankList[1].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
