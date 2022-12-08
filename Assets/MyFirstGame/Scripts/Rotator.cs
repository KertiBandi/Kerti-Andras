
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space rotationSpace; //világkordináta, vagy lokális
    [SerializeField] Vector3 axis = Vector3.up;

    void Update()
    {

        float angle = angularSpeed * Time.deltaTime;
        transform.Rotate(axis,angle, rotationSpace) ;
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 center = transform.position;

        Vector3 dir = axis.normalized;
        if(rotationSpace == Space.Self)
        {
            dir = transform.TransformDirection(dir);

           // transform.InverseTransformPoint(Vector3.up);  irány transzformálása
        }


        Vector3 a = center + dir;
        Vector3 b = center - dir;


        Gizmos.DrawLine(a,b);


    }
}
