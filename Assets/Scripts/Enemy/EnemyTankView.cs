using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankView : MonoBehaviour
{
    private EnemyTankController enemyTankController;
    public Rigidbody rb;
    public MeshRenderer[] childs;

    public void SetTankController(EnemyTankController _enemyTankController){
        enemyTankController = _enemyTankController;
    }

    public Rigidbody GetRigidbody(){
        return rb;
    }

    public void ChangeColor(Material color){
        for(int i = 0; i < childs.Length; i++)
            childs[i].material = color;
    }
}
