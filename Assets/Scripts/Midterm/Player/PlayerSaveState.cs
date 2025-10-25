using UnityEngine;

public class PlayerSaveState : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public void SavePlayerData()
    {
        PlayerPrefs.SetInt("PlayerHealth", playerHealth.health);
        Debug.Log("Player data saved.");
    }
}