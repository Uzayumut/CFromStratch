using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Warrior warrior = new Warrior();
        warrior.WarriorInfo();
        warrior.health = 3;
    }
    void Defense()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
