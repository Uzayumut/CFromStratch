using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
 //Type Name Value
    int power = 15;//digit
    double health = 100.5;//64 decimal
    float armor = 200.5f;//32

    string name = "hope";
    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //This game started do something

        if (isAlive==false)
        {
            Debug.Log("Player is dead");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
