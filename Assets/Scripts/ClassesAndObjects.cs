using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesAndObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Player warrior = new Player();
        warrior.PlayerInfo();

        Player mage = new Player();
        mage.role = "Mage";
        mage.health = 150;
        mage.PlayerInfo();

        mage = warrior;

        print("\n");

        warrior.PlayerInfo();
        mage.PlayerInfo();

        mage.role = "Rogue";
        mage.health = 120;

        print("\n");

        warrior.PlayerInfo();
        mage.PlayerInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Player 
{
    public string role = "Warrior";
    public float health = 200;
    public void PlayerInfo()
    {
        Debug.Log("The role of a Player is " + role + "and the health is " + health);
    }
}
