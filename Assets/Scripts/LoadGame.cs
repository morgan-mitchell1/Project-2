using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public string LevelToLoad;
    public void PlayGame()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void LoadInfo()
    {
        SceneManager.LoadScene("Info");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
