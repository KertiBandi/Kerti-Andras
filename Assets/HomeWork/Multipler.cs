
using System;
using UnityEngine;

public class Multipler : MonoBehaviour
{
   
    void Start()
    {
        int a =1;
        int b=1;

        for (a = 1; a <= 10; a++)
        {
            for (b = 1; b <= 10; b++) 
            {

                Debug.Log($"{a} x {b} = {a * b}");
            }
        }


       



    }

}
