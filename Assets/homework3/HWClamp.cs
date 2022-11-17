using UnityEngine;

public class HWClamp : MonoBehaviour
{
    float Clamp(float number, float min, float max) // k�t r�tk� k�z� szor�tja a megadott sz�mot
    {
        if (number > max)
        {
            return max;
        }
        else if (number < min)
        {
            return min;
        }
        else
        {
            return number;
        }


    }

    float Clamp01(float number)
    {
        return Clamp(number, 0, 1);
    }


}