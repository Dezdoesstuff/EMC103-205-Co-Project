using UnityEngine;

public interface IEnemyAI
{
    void StartChasing();
}

public class EnemyAI : IEnemyAI
{
    public void StartChasing()
    {
        Debug.Log("Enemy is chasing the player.");
    }
}

public class GameManager : MonoBehaviour
{
    [SerializeField] private MonoBehaviour enemyAIComponent; // drag EnemyAI here
    private IEnemyAI enemyAI;

    void Awake()
    {
        enemyAI = enemyAIComponent as IEnemyAI;
    }

    void Start()
    {
        enemyAI?.StartChasing();
    }
}