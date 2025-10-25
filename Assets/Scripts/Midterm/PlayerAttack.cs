using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Dictionary<string, Action> attacks;

    private void Start()
    {
        // Register all attacks here
        attacks = new Dictionary<string, Action>()
        {
            { "Fire", FireAttack },
            { "Ice", IceAttack }
        };
    }

    public void Attack(string attackType)
    {
        if (attacks.ContainsKey(attackType))
            attacks[attackType].Invoke();
        else
            Debug.Log("Player used Normal Attack!");
    }

    private void FireAttack()
    {
        Debug.Log("Player used Fire Attack!");
    }

    private void IceAttack()
    {
        Debug.Log("Player used Ice Attack!");
    }
}