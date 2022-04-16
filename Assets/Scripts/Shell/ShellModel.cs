using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellModel
{
    private ShellController shellController;
    public float movementSpeed;
    public bool destructible;

    public ShellModel(float _movementSpeed){
        movementSpeed = _movementSpeed;
    }
    
    public void SetShellController(ShellController _shellController){
        shellController = _shellController;
    }
}
