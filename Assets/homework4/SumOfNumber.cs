using UnityEngine;

public class SumOfNumber : MonoBehaviour
{
    [SerializeField] int baseNumber;
    [SerializeField] int sumOfNumber;

    private void OnValidate()
    {
        sumOfNumber = SumOfNumbers(baseNumber);
    }

    int SumOfNumbers (int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;

        }
        return sum;
            

    }
}
