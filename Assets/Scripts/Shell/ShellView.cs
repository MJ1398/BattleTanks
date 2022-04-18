using UnityEngine;

public class ShellView : MonoBehaviour
{
    private ShellController shellController;
    public Rigidbody rb;
    public MeshRenderer[] childs;

    private void Update() {
        shellController.Move();
    }

    public void SetShellController(ShellController _shellController){
        shellController = _shellController;
    }

    public void ChangeColor(Material color){
        for(int i = 0; i < childs.Length; i++)
            childs[i].material = color;
    }

    private void OnTriggerEnter(Collider other) {
        if(shellController.IsDestructible()){
            if(other.tag == "Player"){
                TankView player = other.GetComponent<TankView>();
                player.Hit(shellController.getDamage());
            }
            Destroy(gameObject);
        } 
    }

    private void OnTriggerExit(Collider other) {
        shellController.SetDestructible();
    }
}
