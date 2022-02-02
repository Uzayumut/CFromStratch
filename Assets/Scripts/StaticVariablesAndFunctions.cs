using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariablesAndFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Gamer.Health(3);
        Gamer.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
