using UnityEngine;

public class ShellController
{
    private ShellModel shellModel;
    private ShellView shellView;

    public ShellController(ShellModel _shellModel, ShellView _shellView, Transform transform){
        shellModel = _shellModel;
        shellView = GameObject.Instantiate<ShellView>(_shellView, transform.position, transform.rotation);
        shellModel.SetShellController(this);
        shellView.SetShellController(this);
    }

    public void Move(){
        shellView.rb.velocity = shellView.transform.forward * shellModel.movementSpeed;
    }

    public void SetDestructible(){
        shellModel.destructible = true;
    }

    public bool IsDestructible(){
        return shellModel.destructible;
    }

    public int getDamage(){
        return shellModel.damage;
    }
}
