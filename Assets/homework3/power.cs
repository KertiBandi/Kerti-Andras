using UnityEngine;

public class power : MonoBehaviour
{

    [SerializeField] int baseNumber;
    [SerializeField] int exponent;
    [SerializeField] int result;

    private void OnValidate()
    {
        result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
            
        }
        
    }
}
