using UnityEngine;

public class Math : MonoBehaviour
{
    [SerializeField] int number;

    [SerializeField] int abs;
    [SerializeField] int sign;

    void OnValidate()
    {
        abs = AbsoluteValue(number);
        sign = (int) Sign(number);


        
    }
    int AbsoluteValue(int num)
    {
        if(num>0)
        {
            return num;
        }
        else
        {
            return -num;
        }

    }

    float Sign(float num)
    {
        if (num > 0)
        {
            return 1;
        }

        return -1;


    }

    float Floor(float num)
    {
        float remainder = num % 1;
        return num - remainder;


        //return (int)num;

    }

    float Ceil(float num)
    {
        float remainder = num % 1;

        if (remainder == 0)
        {
            return num;
        }


        return num + 1 - remainder;



    }

    float Round(float num)
    {
        float remainder = num % 1;

        if (remainder < 0.5f)
        {
            return Floor(num);
        }
        else
        {
            return Ceil(num);
        }


    }



}
