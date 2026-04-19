using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HealthUI : MonoBehaviour
{
    private int health = 100;
    public TextMeshProUGUI text;

    public void decreaseHealth()
    {
        health -= 25;
        text.text = "Health: " + health;
        if (health <= 0)
        {
            SceneManager.LoadScene("Game_Over");
        }
    }
}