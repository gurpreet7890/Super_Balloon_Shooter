using UnityEngine;

public class Balloon : MonoBehaviour
{
    public ScoreManager scoreManager; 
    public GameOverManager gameOverManager; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("GameOverTrigger"))
        {
            // Notify the GameOverManager that a balloon passed the trigger
            FindObjectOfType<GameOverManager>().BalloonPassed();
            Destroy(gameObject); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the balloon was hit by another object with a collider
        if (collision.gameObject != null)
        {
            Pop(); 
        }
    }

    public void Pop()
    {
        
        if (scoreManager != null)
        {
            scoreManager.BalloonPopped();
        }

        
        Debug.Log("Balloon popped!");

        // Deactivate the balloon
        gameObject.SetActive(false);
    }
}
