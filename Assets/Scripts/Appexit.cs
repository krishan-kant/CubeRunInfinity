using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Appexit : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void loadNext()
    {
        SceneManager.LoadScene(1);
    }
}
