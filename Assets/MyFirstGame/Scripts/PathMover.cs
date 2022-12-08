using UnityEngine;

public class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 point1, point2, point3;
    [SerializeField] float speed;

    [SerializeField, Range(0, 1)] float StartPosition;

    [SerializeField] Color color1, color2;
    Vector3 target;
    bool route1, route2;


    private void OnValidate()
    {

        transform.position = Vector3.Lerp(point1, point2, StartPosition);
    }

    private void Start()
    {
        
        route1 = true;
        route2 = true;

    }

    void Update()
    {
        
       

        if (route1 && route2 )
        {
            target = point2;
    
        }
        if (!route1 && route2)
        {
            target = point3;

        }
        if (!route1 && !route2)
        {
            target = point2;

        }
        if (route1 && !route2)
        {
            target = point1;

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);


        if ((transform.position == point2) && route2)
        {
            route1 = !route1;
        }
        if (transform.position == point3)
        {
            route2 = !route2;
        }
        if ((transform.position == point2) && !route2)
        {
            route1 = !route1;

        }
        if (transform.position == point1)
        {
            route2 = !route2;
        }
       





    }

    private void OnDrawGizmos()  //gizmost rajzolunk
    {
       Gizmos.color = Color.Lerp(color1, color2, StartPosition);
        Gizmos.DrawWireSphere(point1, 0.2f);
        Gizmos.DrawWireSphere(point2, 0.2f);
        Gizmos.DrawWireSphere(point3, 0.2f);
        Gizmos.DrawLine(point1, point2);
        Gizmos.DrawLine(point2, point3);
    }



    // Az eredeti!
    /* [SerializeField] Vector3 point1, point2;
     [SerializeField] float speed;

     [SerializeField, Range(0, 1)] float StartPosition;

     [SerializeField] Color color1, color2;

     bool forward;


     private void OnValidate()
     {

         transform.position = Vector3.Lerp(point1,point2, StartPosition);
     }

     private void Start()
     {
                forward = true;
     }

     void Update()
     {
         Vector3 target = forward ? point2 : point1;  //feltételes értékadás



         transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

         if (transform.position == target)
         {
             forward = !forward;
         }



     }

     private void OnDrawGizmos()  //gizmost rajzolunk
     {
         Gizmos.color = Color.Lerp(color1, color2, StartPosition);
         Gizmos.DrawWireSphere(point1, 0.2f);
         Gizmos.DrawWireSphere(point2, 0.2f);
         Gizmos.DrawLine(point1, point2);

     }
    */
}
