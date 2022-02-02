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
    public Arrays arrays;

    private GameObject warrior;
    void Start()
    {
        war = GameObject.Find("Player").GetComponent<Warrior>();
        warrior = GameObject.Find("Player").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
