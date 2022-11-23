using System;
using UnityEngine;

public class PitagorianNumber : MonoBehaviour
{
    [SerializeField] int a,b, c;
    [SerializeField] bool isPythagorianNumber;

    private void OnValidate()
    {
        isPythagorianNumber = isPythagorian(a, b, c);
    }
    
    
    bool isPythagorian (int a, int b, int c)
    {


        int bigest = Mathf.Max(a,b,c);
        int smallest = Mathf.Min(a,b,c);
        int theThirdOne = a + b + c - bigest - smallest;

        return (smallest * smallest) + (theThirdOne*theThirdOne) == (bigest * bigest);
        

    }


}
