using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSpawner : MonoBehaviour
{   
    public ShellView shellView;
    public float movementSpeed;

    public void CreateShell(){
        ShellModel shellModel = new ShellModel(movementSpeed);
        ShellController tankController = new ShellController(shellModel, shellView, transform);
    }
}
