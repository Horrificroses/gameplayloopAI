using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;
    public GameObject bookPrefab; // Assign the book prefab in the Inspector

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy has died.");
        Instantiate(bookPrefab, transform.position, Quaternion.identity); // Instantiate the book prefab at the enemy's position
        Destroy(gameObject); // Destroy the enemy GameObject
    }
}
