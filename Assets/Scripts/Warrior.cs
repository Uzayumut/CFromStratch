using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Inheritance
{
    public float health=200;
    public string role="Warrior";
    public Warrior()
    {

    }
    public Warrior(string _role,float _health)
    {
        this.role = _role;
        this.health = _health;
    }
    private void Start()
    {
        
    }
    public void WarriorInfo()
    {
        print("This player is role "+role+" and the health is "+health);
    }
    public void Attack()
    {
        print("The warrior attacking");
    }

}
