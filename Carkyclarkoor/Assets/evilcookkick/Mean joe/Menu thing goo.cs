using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuThing : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void HARDMODE()
    {
        SceneManager.LoadScene("HardMode");
    }
}
