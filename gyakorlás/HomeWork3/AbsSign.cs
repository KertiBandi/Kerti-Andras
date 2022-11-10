
using UnityEngine;

public class AbsSign : MonoBehaviour
{
    [SerializeField] int x;
    [SerializeField] int y;
    [SerializeField] int z;

    void OnValidate()
    {

        

        if (x < 0)
        {
            y = x *- 1;
        }
        else
        {
            y = x;
        }

        Mathf.Sign(z);




    }

}
