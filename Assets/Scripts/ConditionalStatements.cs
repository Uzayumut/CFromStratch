using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 7;
        int b = 5;
        int c = 4;
        //**************************************************IF, ELSE IF, ELSE

        //< , > , <= , >= , ==     ConditionalStatements (&&-and   ||-or

        if (a > b&& a > c)//(>) //AND
        {
            print("'A' is greater than 'B' AND 'A' is greater than 'C'");
            if(b > c)
            {
                print("'B' is greater than 'C'");
            }
            else if(b < c)
            {
                print("'B' is smaller than 'C'");
            }
            else
            {
                print("'B' is equal to 'C'");
            }
        }

        else if (a < b || a > c) //OR
        {
            print("'A' is greater than 'B' OR 'A' is greater than 'C'");
        }
        else if (a == b)
        {
            print("A is equal to B ");
        }
        else if(a<=b)//(<)
        {
            print("A in smaller than B");
        }
        
        if (true)
        {
            //this block of code
            print("This is true");
        }
        //*********************************SWITCH CASE********************************
        switch (a)
        {
            case 7:
                print("A is equal to 10");
                break;
            case 1:
                break;
            case 3:
                break;
            default:
                print("Default value");
                break;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
