using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GemsUI : MonoBehaviour
{
    public int gemsTotal;
    public string SceneToLoad;

    public int gems = 0;
    public TextMeshProUGUI text;

    public void addGem()
    {
        gems++;
        text.text = "Gems: " + gems + " / " + gemsTotal;
        if (gems == gemsTotal)
        {
            SceneManager.LoadScene(SceneToLoad);
            gems = 0;
        }
    }

    public void resetGems()
    {
        gems = 0;
    }
}