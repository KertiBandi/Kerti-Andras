using UnityEngine;

public class ArrayMath : MonoBehaviour
{
    [SerializeField] float[] arrayMaths;
    [SerializeField] float sum;
    [SerializeField] float product;
    [SerializeField] float mean;
    [SerializeField] float[] arrayMathInvers;

    private void OnValidate()
    {
        sum = 0;
        product = 1;
        for (int i = 0; i < arrayMaths.Length; i++)
        {
            sum += arrayMaths[i];
            product *= arrayMaths[i];   
            
        }

        mean = sum / arrayMaths.Length;

       /* arrayMathInvers = new float[arrayMaths.Length];

        for (int i = arrayMaths.Length-1; i >=0; i--)
        {
            arrayMathInvers[i] = arrayMaths[i];
        }
       */



    }



}
