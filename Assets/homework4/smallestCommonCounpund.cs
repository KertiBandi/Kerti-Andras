using UnityEngine;

public class smallestCommonCounpund : MonoBehaviour
{
    [SerializeField, Min(1)] int largeerNumber;
    [SerializeField,Min(1)] int smallerNumber;
    
    [SerializeField] int result;


    private void OnValidate()
    {
        int numberToTest = largeerNumber;

        while (numberToTest % smallerNumber !=0)
        {
            numberToTest += largeerNumber;
        }
        result = numberToTest;
    }
}
