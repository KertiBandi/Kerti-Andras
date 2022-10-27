using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int number;

    [SerializeField] string parity;
    [SerializeField] string domain;
    [SerializeField] string danger;
    [SerializeField] string divideableBy3;

    void OnValidate()
    {
        bool isEven = number % 2 == 0;

        if (isEven)
        { 
            parity = "PAROS";
        }
        else
        { parity = "Paratlan";
        }
       
        //---------------------------------------

        if(number>0)
        {
            domain = "Pozitiv";
        }
        else if(number<0)
        {
            domain = "Negativ";
        }
        else
        {
            domain = "Nulla";
        }
     //-------------------------------
     if (number>10)
        {
            danger = "Low";
        }
     else if (number > 35)
        {
            danger = "Medium";
        }
     else if (number > 60)
        {
            danger = "High";
                }
     else 
        {
            danger = "Very high";
        }
        //----------------------------------
        divideableBy3 = number % 3 == 0 ? "Osztható" : "Nem osztható";


        




    }

    private void Start()
    {
        // Ciklusok--------------------------

        int i = 1;

        while(i<=5) 

        {
            Debug.Log(i);
            i++;
        }

        for (int j = 0; j < 5; j++)
        {
            Debug.Log(j);
        }

        for (int j = 10; j >= 1; j--)
        {
            Debug.Log(j);
        }

        for (int j = 0; j <= 100; j+=3) //3am osztható számok
        {
            Debug.Log(j);

        }
        // 1tõl 100 ig számok 3-al és 7el oszthatók

        for (int k = 1; k < 100; k++)
        {
            if (k % 3 == 0 && k % 7 == 0)
                Debug.Log(k);

        }
      

    }

}
