using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversNumbers : MonoBehaviour
{
    [SerializeField] int[] values = Array.Empty<int>();


    private void Start()
    {
        ChangeOrder(values);
    }

    void ChangeOrder(int[] array)
    {
        if (array == null)
            return;

        for (int i = 0; i < array.Length/2; i++)
        {
            int i2 = array.Length - 1 - i;

            int temp = array[i];
            array[i] = array[i2];
            array[i2] = temp;




        }



    }




}
