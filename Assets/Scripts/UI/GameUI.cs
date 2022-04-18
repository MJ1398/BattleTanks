using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text playerHealth;

    public void UpdateUI(int health)
    {
        playerHealth.text = "Health: " + health;
    }
}
