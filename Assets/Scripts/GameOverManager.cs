using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class GameOverManager : MonoBehaviour
{
    public int balloonPassCount = 0; 
    public int passThreshold = 3; 
    public GameObject gameOverPanel; 

    public void BalloonPassed()
    {
        balloonPassCount++;
        Debug.Log("Balloon passed the trigger! Count: " + balloonPassCount);

        if (balloonPassCount >= passThreshold)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over triggered!");
        gameOverPanel.SetActive(true); 
        Time.timeScale = 0; 
    }

    
    public void RestartGame()
    {
        Debug.Log("Restarting game...");
        Time.timeScale = 1; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    
    public void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit(); 

        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#endif
    }
}
