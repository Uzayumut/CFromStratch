using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer : MonoBehaviour
{
    public static void Attack()
    {
        print("Gamer is attacking");
    }
    public static int Health(int x)
    {
        print(x);
        return x;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
