using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isGamePaused = true;

    public void backToMainMenu() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        SceneManager.LoadScene("GameTitleScene");
    }
}
