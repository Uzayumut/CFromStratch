using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numbers = new int[10];
        //numbers[0] = 5;//first number
        //numbers[9] = 10;//last number,
        //numbers[10] = 11; //error
        //print(numbers[0]);
        //print(numbers.Length);
        //print(numbers[numbers.Length - 1]);

        //*********************************************************************FOR***********************************************************

        //****************************************************Random Value**********************************
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(0, 100);//Random value
            print("Number index is " + i + "And the value is" + numbers[i]);
        }
        //****************************************************Certain Consecutive Number***************************

        int[] numbers2 = new int[10];
        int x = 5;
        for (int i = 0; i < numbers2.Length; i++)
        {
            numbers[i] = x;
            x += 5;
            print("Number2 index is " + i + "And the value is" + numbers2[i]);
        }

        //*******************************************************************FOREACH*************************************************************
        foreach (var number in numbers)
        {
            print("Value of Numbers" + number);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
