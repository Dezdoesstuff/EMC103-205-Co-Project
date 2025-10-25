using UnityEngine;


//Refactor the following code to follow the Interface Segregation Principle:
public interface IMovable
{
    void Move();
}

public interface IAttacker
{
    void Attack();
}

public interface ISpellCaster
{
    void CastSpell();
}

public class Warrior : IMovable, IAttacker
{
    public void Move() => Debug.Log("Warrior moves.");
    public void Attack() => Debug.Log("Warrior attacks.");
}