using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    void Start()
    {
        Debug.Log("AAA");
        CountUntil("X",12);
        Debug.Log("BBB");
        CountUntil("Y",34);
        Debug.Log("CCC");
        CountUntil("Z",56);
        Debug.Log("--------------------------");

        int a = Power(5, 3);
        int b = Power(4, 6);
        int c = Power(2, 10);

        Debug.Log($"{a} --- {b} --- {c}");

    }
    void CountUntil(string st, int count)
    {
        for (int i = 1; i < count; i++)
        {
            Debug.Log(st + " " + i);

        }
    }

    int Power(int baseNumber, int exponent)
    {
        int a = 1;
        for (int i = 0; i < exponent; i++)
        {
            a *= baseNumber;
        }

        return a;
    }

}
