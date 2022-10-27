using UnityEngine;

public class OnValidatePractice : MonoBehaviour
{
    [SerializeField] int intSetting;
    [SerializeField] float floatSetting;
    [SerializeField] string stringSetting;
    [SerializeField] bool boolSetting;
    [SerializeField] int startAmmo=34;

    [Space]  //hely a v�ltoz�k k�z�tt
    [SerializeField] float num1,num2;
    [SerializeField] float sum;

    int fieldVariable = 55; //Field / Tagv�ltoz�  ha a start el�tt �ll

    void OnValidate()   //akkor indul, amikor v�ltoznak a field komponensek
    {
        sum = num1 + num2;

    }

    void Start()  //akkor indul, amikor l�trej�n a komponens
    {
        int localVariable = 66;

        int summa = localVariable + fieldVariable+intSetting;

        Debug.Log(summa);



    }
}
