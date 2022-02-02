using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndFunctions : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        int[] numbers = new int[10];
        ProcessArrays(numbers,0,100);
        numbers = ProcessArrays2(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            print("This value 2 is " + numbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ProcessArrays(int[] numbers, int min, int max)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(min, max);
            print("This value is " + numbers[i]);
        }
    }
    int[] ProcessArrays2(int[] numbers)
    {
        numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(0, 100);
        }
        return numbers;
    }
    
}
