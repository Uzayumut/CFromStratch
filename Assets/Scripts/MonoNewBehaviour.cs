using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoNewBehaviour : MonoBehaviour
{
    [SerializeField]//The Inspector screen visible
    private string role;
    [HideInInspector]//The ınspector screen not visible
    public int health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
