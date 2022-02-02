using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        StartCoroutine(PrintAfterDelay(2));//start coroutine code.
        StartCoroutine("PrintAfterDelay");//same
        StopCoroutine("PrintAfterDelay");//stop coroutine code
        StopAllCoroutines();//stop all coroutine code
        //Time.timeScale = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator PrintAfterDelay(float time)//How much does it need to wait
    {
        yield return new WaitForSeconds(time);
        //yield return new WaitForSecondsRealtime(2);
        print("something");
    }
}
