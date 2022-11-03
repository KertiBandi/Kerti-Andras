using UnityEngine;

public class SumOfNumbers : MonoBehaviour
{

    [SerializeField, Min(1)] int number = 10;
    [SerializeField] int sum;

    private void OnValidate()
    {
        sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;



        }
        
    }

}
