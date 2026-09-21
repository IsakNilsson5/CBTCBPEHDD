using UnityEngine;
using UnityEngine.SceneManagement;
public class youbeatmygameyoulearntlot : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }  
    public void Secretmodetotally()
    {
        SceneManager.LoadScene("HardMode");
    }
}
 