using UnityEngine;


//Consider the following class hierarchy.
//Identify and fix any potential Liskov Substitution Principle violations:
public abstract class Enemy
{
    public abstract void Attack();
}

public class MeleeEnemy : Enemy
{
    public override void Attack() => Debug.Log("Enemy attacks!");
}

public class GhostEnemy : Enemy
{
    public override void Attack() => Debug.Log("Haunts the player!");
}