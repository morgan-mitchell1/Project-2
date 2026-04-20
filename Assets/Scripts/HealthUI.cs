using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HealthUI : MonoBehaviour
{
    private int health = 100;
    public TextMeshProUGUI text;
    public string thisLevel;

    public void decreaseHealth()
    {
        health -= 25;
        text.text = "Health: " + health;
        if (health <= 0)
        {
            GameOver.LevelToLoad = thisLevel;
            FindFirstObjectByType<GemsUI>()?.resetGems();
            SceneManager.LoadScene("GameOver");
        }
    }
}