using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;
    private GameUI gameUI;
    private GameOverUI gameOverUI;

    public TankController(TankModel _tankModel, TankView _tankView, GameUI _gameUI, GameOverUI _gameOverUI){
        tankModel = _tankModel;
        gameUI = _gameUI;
        gameOverUI = _gameOverUI;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
        tankView.ChangeColor(tankModel.color);
        gameUI.gameObject.SetActive(true);
        gameUI.UpdateUI(tankModel.health);
    }

    public void Move(float movement, float movementSpeed){
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed){
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed,  0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public void Fire(){
        tankView.shellSpawner.CreateShell();
    }

    public void ReduceHealth(int damage){
        tankModel.health -= damage;
        gameUI.UpdateUI(tankModel.health);
        if(tankModel.health <= 0)
            GameOver();
    }

    public void GameOver(){
        gameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(true);
        tankView.isAlive = false;
    }

    public TankModel GetTankModel(){
        return tankModel;
    }
}
