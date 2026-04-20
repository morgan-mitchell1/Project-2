using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static string LevelToLoad;

    public void StartOver()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}