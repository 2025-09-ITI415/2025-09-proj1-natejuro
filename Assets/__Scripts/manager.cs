using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{

    public static manager instance;
    [SerializeField]private GameObject endGameCanvas;

    private void Awake() {
        if (instance == null) {
        instance = this;
        }
        
        Time.timeScale = 1f;
    }

    public void GameOver() {
        endGameCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
