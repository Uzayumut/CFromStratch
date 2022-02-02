using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour
{
    public string name="Rage";
    public int power=15;
    public Constructor()
    {
        PowerInfo();
    }
    public Constructor(string _name,int _power)
    {
        this.name = _name;
        this.power = _power;
        PowerInfo();
    }
    void PowerInfo()
    {
        Debug.Log("The name of a Power is " + name + " and the power strengt is " + power);
    }
    void Start()
    {
        Player warrior = new Player();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class Player2
    {
        Constructor rage = new Constructor("Rage",15);
        Constructor fire = new Constructor("Fire", 10);
    }
}
