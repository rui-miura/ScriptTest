using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{ 
    void Start ()
    {
       
        int[] array = new int[5];

       
        array[0] = 30;
        array[0] = 20;
        array[1] = 17;
        array[2] = 2;
        array[3] = 27;
        array[4] = 36;
                
         for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        
        
        
        for (int i = 4; i != -1; i--)
        {
            Debug.Log(array[i]);
        }
    }

        
    void Update()
    {

    }
}
