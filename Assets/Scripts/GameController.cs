using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class GameController : MonoBehaviour
{
    public GameObject playButton; 

    private void Start()
    {
        
        Time.timeScale = 0; 
    }

    public void StartGame()
    {
        
        Time.timeScale = 1; 
        playButton.SetActive(false);
    }
}
