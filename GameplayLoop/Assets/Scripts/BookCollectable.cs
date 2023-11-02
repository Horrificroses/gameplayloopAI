using UnityEngine;
using UnityEngine.UI;

public class BookCollectible : MonoBehaviour
{
    public int scoreValue = 10; // Score value to be added when the book is collected
    public Text collectedText; // Assign the UI Text element in the Inspector

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerScore playerScore = collision.gameObject.GetComponent<PlayerScore>();
            if (playerScore != null)
            {
                playerScore.AddScore(scoreValue); // Add the score value to the player's score
            }
            ShowCollectedText(); // Show the collected text
            Collect(); // Collect the book
        }
    }

    void ShowCollectedText()
    {
        if (collectedText != null)
        {
            collectedText.text = "Book Collected"; // Update the text to display "Book Collected"
            // You can also add additional logic here, such as fading out the text after a few seconds
        }
    }

    void Collect()
    {
        Debug.Log("Book collected.");
        Destroy(gameObject); // Destroy the book GameObject
    }
}
