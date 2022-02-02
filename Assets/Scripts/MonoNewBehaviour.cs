using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoNewBehaviour : MonoBehaviour
{
    [SerializeField]//The Inspector screen visible
    private string role;
    [HideInInspector]//The ınspector screen not visible
    public int health;
    private Warrior war;
    void Start()
    {
        war = GameObject.Find("Player").GetComponent<Warrior>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
