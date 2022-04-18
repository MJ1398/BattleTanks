public class ShellModel
{
    private ShellController shellController;
    public float movementSpeed;
    public bool destructible;
    public int damage;

    public ShellModel(float _movementSpeed, int _damage){
        movementSpeed = _movementSpeed;
        damage = _damage;
    }
    
    public void SetShellController(ShellController _shellController){
        shellController = _shellController;
    }
}
