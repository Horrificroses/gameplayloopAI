using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private bool hasBook = false; // Flag to track if the player has a book

    // Method to add a book to the player's inventory
    public void AddBook()
    {
        hasBook = true;
        Debug.Log("Book added to inventory.");
    }

    // Method to check if the player has a book in their inventory
    public bool HasBook()
    {
        return hasBook;
    }

    // Method to remove the book from the player's inventory
    public void RemoveBook()
    {
        hasBook = false;
        Debug.Log("Book removed from inventory.");
    }
}
