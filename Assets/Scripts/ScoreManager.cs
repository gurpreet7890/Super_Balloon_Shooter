using UnityEngine;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public int score { get; private set; }
    public TextMeshProUGUI scoreText; 

    private void Start()
    {
        score = 0;
        DisplayScoreUI(); 
    }

    
    public void BalloonPopped()
    {
        // Increment score by 1
        score += 1;
        Debug.Log("Score: " + score);
        
        
        DisplayScoreUI();
    }

    
    private void DisplayScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "" + score;
        }
    }
}
