using UnityEngine;

public class ShellSpawner : MonoBehaviour
{   
    public ShellView shellView;
    public float movementSpeed;
    public int damage;

    public void CreateShell(){
        ShellModel shellModel = new ShellModel(movementSpeed, damage);
        ShellController tankController = new ShellController(shellModel, shellView, transform);
    }
}
