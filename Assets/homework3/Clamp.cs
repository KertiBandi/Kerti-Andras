using UnityEngine;

public class ClampFuggv : MonoBehaviour
{
    float Clamp(float number, float min, float max)
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


}
