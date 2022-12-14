using System.Collections.Generic;  // random számokhoz kell
using UnityEngine;


public class MinMax : MonoBehaviour
{
    [SerializeField] float [] array;
    [SerializeField] int min, max;
    

    private void OnValidate()
    {
        for (int i = 0; i < array.Length; i++)
        {
            int random = Random.Range(0, 100);
            array[i] = random;

        }





    }


}
