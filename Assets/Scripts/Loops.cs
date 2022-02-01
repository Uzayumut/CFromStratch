using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //******************************for*************************************

        for (int i = 0; i < 10; i++)
            {
                print("i= "+i);
            }

        //*******************************while***********************************

        int y=0;

        while ( y<=10)
        {
            
            print("y= "+y);
            y++;
        }

        //*********************************do*********************************

        int z = 0;
        do
        {
            print("z= "+z);
            z++;
        } while (z<10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
