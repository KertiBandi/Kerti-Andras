using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] intArray;
    [SerializeField] int[] intArray2 = new int[10];
    [SerializeField] int[] intArray3 = new int[10];
   

    [SerializeField] List<int> intList;
    [SerializeField] List<int> intList2;

    private void Start()
    {
        for (int i= 0; i < intArray.Length; i++)
        {
            int element = intArray[i];
            Debug.Log(element);
        }
        foreach (int element in intArray)// a kettõ ugyanaz
        {
            Debug.Log(element);
        }
        for (int i = intArray.Length - 1; i>=0; i--)
        {
            int element = intArray[i];
            Debug.Log(element);
        }

                
        for (int i = 1; i<=intArray2.Length;i++)
        {
            intArray2[i-1] = i * i;
        }

        //fibonacci-----------------------------------------------------------
        intArray3[0] = 1;
        intArray3[1] = 1;

        for (int i = 2; i < intArray2.Length; i++)
        {
            intArray3[i] = intArray3[i - 1] + intArray3[i - 2];
           
        }
        //------------------------------------------------------------------------
        List<string> stringList =new List<string>();
        for (int i =0; i < 10; i++)
        {
            int num = (i + 1) * (i + 1);
            stringList.Add(num.ToString());
        }
       bool succesfullRemove = stringList.Remove("50");// kiveszem az 50-es értéket tartalmazó elemet
        stringList.RemoveAt(3); // kiveszi a 3. elemet
        stringList.Clear(); //kiüríti a teljes string listát


        //---------------------------------------

        intList2 = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            int random = Random.Range(1, 100);
            intList2.Add(random);
        }
        //Töröljük a páros elemeket
        for (int i = 0; i < intList2.Count; i++)
        {
           

            if ((intList2[i] % 2) == 0)
            {
                intList2.RemoveAt(i);
                i--;
            }
        }
        /*hátulról haladva nem változik az indexelés
        for (int i = intList2.Count-1; i >=0; i--)
        {


            if ((intList2[i] % 2) == 0)
            {
                intList2.RemoveAt(i);
                
            }
        }*/
        intList2.Sort();
        stringList.Insert(5, "Alma");
        bool c = stringList.Contains("Körte");
        int KorteIndex = stringList.IndexOf("Körte");

        List<int> intList5 = new List<int>(intArray);
        int[] intArray5 = intList5.ToArray();

    }


}
