using UnityEngine;

public class BizzBuzz : MonoBehaviour
{
    [SerializeField] int number;


    void start()
    {


        for (int i = 1; i < number; i++)
        {
            if (i % 15 == 0)
            
                Debug.Log("BizzBuzz");
            
            else if (i % 5 == 0)
            
                Debug.Log("Buzz");

            
            else if (i % 3 == 0)
            
                Debug.Log("Bizz");
                
            else
            

                Debug.Log(i);
            

            

        }
        



    }




}
