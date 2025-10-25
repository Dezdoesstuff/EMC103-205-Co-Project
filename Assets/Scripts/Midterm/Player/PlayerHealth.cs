using UnityEngine;

//Refactor the following script to follow the Single Responsibility Principle:
public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Debug.Log("Player Died");
        Destroy(gameObject);
    }
}