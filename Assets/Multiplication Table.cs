using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    int Multiply(int number1 , int number2)
    {
        return number1*number2;
    }
    void Start()
    {
        int number = 5;
        for(int i = 1; i<= 10 ; i++)
        {
            int result = Multiply(number,i);
            Debug.Log(number + " x " + i +" = "+ result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
