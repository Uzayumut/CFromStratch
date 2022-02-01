using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CalculateTwoNumbers();
        CalculateTwoNumbers(2, 3);
        CalculateTwoNumbers(7, 4);

        print(IntCalculateTwoNumbers()) ;
        print(IntCalculateTwoNumbers(4,7));
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }
    //Functions
    void Movement()//VOİD function means it does not return anything.
    {
        //block of code
        
    }
    
    void CalculateTwoNumbers()//METHOD WITHOUT PARAMETERS
    {
        int sum = 4 + 5;
        print("The sum of a and b is " + sum);
    }
    void CalculateTwoNumbers(int a,int b)//METHOD WITH PARAMETERS
    {
        int sum = a + b;
        print("The sum of a and b is " + sum);
    }
    int IntCalculateTwoNumbers()//(INT STRİNG BOOL =>RETURN)
    {
        int sum= 3 + 5;
        return sum;
    }
    int IntCalculateTwoNumbers(int a,int b)//(INT STRİNG BOOL =>RETURN) with parameters
    {
        int sum = a + b;
        return sum;
    }
    int CalculateTwoNumbers(int a)
    {
        int sum = a;
        return sum;
    }
}
