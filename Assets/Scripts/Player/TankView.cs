using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;
    public Rigidbody rb;
    public MeshRenderer[] childs;
    public ShellSpawner shellSpawner; 
    GameObject cam;
    public bool isAlive;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
        isAlive = true;
    }

    void Update()
    {
        if(!isAlive){
            cam.transform.SetParent(null);
            Destroy(gameObject);
        }
        Movement();
        PlayerInput();
        if(movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        if(rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotatationSpeed);
    }

    private void Movement(){
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    private void PlayerInput(){
        if(Input.GetKeyDown(KeyCode.Space)){
            tankController.Fire();
        }
    }

    public void Hit(int damage){
        tankController.ReduceHealth(damage);
    }

    public void SetTankController(TankController _tankController){
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody(){
        return rb;
    }

    public void ChangeColor(Material color){
        for(int i = 0; i < childs.Length; i++)
            childs[i].material = color;
    }
}
