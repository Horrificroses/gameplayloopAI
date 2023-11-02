using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private int score = 0; // Initial score value
    public Text scoreText; // Assign the UI Text element in the Inspector
    public Text winText; // Assign the UI Text element for displaying "You won!" in the Inspector

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score; // Update the score text
        }
    }

    // Method to add score
    public void AddScore(int scoreValue)
    {
        score += scoreValue; // Increment the score by the score value
        Debug.Log("Score increased by " + scoreValue + ". Current score: " + score);

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score; // Update the score text
        }

        if (score >= 100 && winText != null)
        {
            winText.text = "You won!"; // Display "You won!" when the score reaches 100
        }
        // You can also update the UI or perform other actions here based on your game's requirements
    }

    // Method to get the current score
    public int GetScore()
    {
        return score;
    }
}
