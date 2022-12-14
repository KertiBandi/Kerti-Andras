using Unity.VisualScripting;
using UnityEngine;

public class vector : MonoBehaviour
{
    [SerializeField] Vector3 a1, a2;
    [SerializeField] Vector3 result;

    [SerializeField] float distance;
    [SerializeField] int jumpNumber;
    [SerializeField] float evenDistance;

    [SerializeField] string message;

    private void OnValidate()
    {
        result = a2-a1;
        result.Normalize();

        //result = NormalFromAToB(a, b); egyszerûbb megoldás

        distance = (a2-a1).magnitude;
        jumpNumber = (int)distance;

        if (distance % 1 != 0)
        {
            jumpNumber += 1;
        }
        evenDistance = distance / jumpNumber;

        //stepCount = Mathf.CeilToInt(distance / 1f);


/*
        Vector3 selfPosition = transform.position;

        float height = selfPosition.y;
        if (height > 0)
            Debug.Log("GameObject már magasabban van mint 0");
       

        */

        Vector3 Directionvec(Vector3 start,Vector3 end)
        {
            return (end - start).normalized;
            

        }


    }




    



}
