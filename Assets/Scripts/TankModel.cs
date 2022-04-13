using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotatationSpeed;

    public TankModel(float _movement, float _rotation){
        movementSpeed = _movement;
        rotatationSpeed = _rotation;
    } 

    public void SetTankController(TankController _tankController){
        tankController = _tankController;
    }
}
