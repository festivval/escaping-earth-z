using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("TESTNAME"); // Replace "GameScene" with your actual game scene name
    }

    public void QuitGame()
    {
        Debug.Log("Game Quit!"); // Just to test in editor
        Application.Quit(); // Only works in a built application
    }
}
