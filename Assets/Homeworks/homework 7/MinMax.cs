using System.Collections.Generic;  // random sz�mokhoz kell
using UnityEngine;


public class MinMax : MonoBehaviour
{
    [SerializeField] float [] array;
    [SerializeField] float min, max;
    

    private void OnValidate()
    {

        for (int i = 0; i < array.Length; i++)
        {
            float random = Random.Range(0, 100);
            array[i] = random;

        }





    }


}
