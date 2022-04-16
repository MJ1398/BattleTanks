using System.Collections;
using System.Collections.Generic;
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
        // if(other.tag == "Player")
        //     other.GetComponent<TankView>().rb.AddForce(transform.position * -20f);
        if(shellController.IsDestructible())
            Destroy(gameObject);
    }
    private void OnTriggerExit(Collider other) {
        shellController.SetDestructible();
    }
}
