using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackRange = 1f; // Range within which the player can attack
    public int damageAmount = 1; // Amount of damage to inflict

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Enemy") && Vector3.Distance(hit.transform.position, transform.position) <= attackRange)
                {
                    Debug.Log("Player hit the enemy.");
                    EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
                    if (enemyHealth != null)
                    {
                        enemyHealth.TakeDamage(damageAmount);
                    }
                }
            }
        }
    }
}
