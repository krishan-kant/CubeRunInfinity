using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enterkey : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("enter"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}