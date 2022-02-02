using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerations : MonoBehaviour
{
    public enum PlayerState
    {
        PlayerDied,
        PlayerWon,
        Prepare,
        Start
    }
    PlayerState pState = PlayerState.Prepare;
    void Start()
    {
        if (pState == PlayerState.Prepare)
        {
            pState = PlayerState.Start;
            print("Init");
        }
        if (pState == PlayerState.Start)
        {
            print("We started");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
