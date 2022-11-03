using UnityEngine;

public class MinMax : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] int min, max;



    void OnValidate()
    {
        if(a < b)
        {
            min = a;

        }
        else
        {
            min = b;

        }

        max = a > b ? a : b;

        //----------------------

        min = Mathf.Min(a, b);

        //-------------------

        min = Minimum(a, b);
        max = Maximum(a, b);

      

        
    }


    int Minimum(int n1, int n2) 
    {


        int result = n1 > n2 ? n2 : n1;


        return result;


    }

    int Maximum(int n1, int n2)
    { 
        if (n1 > n2)
        {
            return n1;

        }
        else
        {
            return n2;
        }
    
    
    
    }

}
