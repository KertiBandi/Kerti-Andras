
using UnityEngine;

public class ArrayFilling : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int[] array;

    private void OnValidate()
    {
        
        array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = i+1;
        }
      



    }



}
