using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenSettings()
    {
        Debug.Log("Otevírám nastavení...");
    }

    public void QuitGame()
    {
        Debug.Log("Hra se ukonèuje.");
        Application.Quit();
    }
}