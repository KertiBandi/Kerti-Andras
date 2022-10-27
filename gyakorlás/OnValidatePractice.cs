using UnityEngine;

public class OnValidatePractice : MonoBehaviour
{
    [SerializeField] int intSetting;
    [SerializeField] float floatSetting;
    [SerializeField] string stringSetting;
    [SerializeField] bool boolSetting;
    [SerializeField] int startAmmo=34;

    [Space]  //hely a változók között
    [SerializeField] float num1,num2;
    [SerializeField] float sum;

    int fieldVariable = 55; //Field / Tagváltozó  ha a start elõtt áll

    void OnValidate()   //akkor indul, amikor változnak a field komponensek
    {
        sum = num1 + num2;

    }

    void Start()  //akkor indul, amikor létrejön a komponens
    {
        int localVariable = 66;

        int summa = localVariable + fieldVariable+intSetting;

        Debug.Log(summa);



    }
}
