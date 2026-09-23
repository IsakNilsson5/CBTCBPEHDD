using UnityEngine;
using UnityEngine.SceneManagement;

public class Stupider : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene(3);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }
}
