using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationWithVariables : MonoBehaviour
{


    

    // Start is called before the first frame update
    void Start()
    {
        //This course
        float a = 12;
        float b = 13;

        //int sum = a + b;//error
        int sum = (int)a + (int)b; //correct
        //Debug.Log(sum);write to console

        string firstName = "Uzay ";
        string lastName = "Bardakci";
        string sumName = firstName + lastName;

        print(sumName + "ıs old this many years" + sum);

        print(sum);//wirte to console

        //this method 
        Collection(6,4);
        Extraction(6,4);
        Divide(6,4);
        Multiply(6,4);

    }

    //Parameterized method
    void Collection(int a,int b)
    {
        int sum = a + b;
        print("Collection=" + sum);
    }
    void Extraction(int a, int b)
    {
        int ext = a - b;
        print("Extraction=" + ext);
    }
    void Divide(float a, float b)
    {
        float div = a / b;
        print("Divide=" + div);
    }
    void Multiply(float a, float b)
    {
        float mlp = a * b;
        print("Multiply=" + mlp);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
