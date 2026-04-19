using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GemsUI : MonoBehaviour
{
    public int gemsTotal;

    private int gems = 0;
    public TextMeshProUGUI text;

    public void addGem()
    {
        gems++;
        text.text = "Gems: " + gems + " / " + gemsTotal;
    }
}