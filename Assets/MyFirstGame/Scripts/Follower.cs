using UnityEngine;

public class Follower : MonoBehaviour
{

    [SerializeField] Transform target; //transform típúsú változó,  
    [SerializeField] float speed = 3;

    /*void Update()
    {

        Vector3 targetPosition = target.position;
        Vector3 selfPosition = transform.position;

        Vector3 direction = targetPosition - selfPosition;
        float distance = direction.magnitude; // magnitudó a vektor hossza


        direction.Normalize();

        float stepDistance = speed * Time.deltaTime;
        if (stepDistance > distance)
        {
            stepDistance = distance;
        }


        transform.position += direction * stepDistance;


        if (direction != Vector3.zero)

            transform.rotation = Quaternion.LookRotation(direction);



    }*/


    void Update()
    {

        Vector3 targetPosition = target.position;
        Vector3 selfPosition = transform.position;

        float stepDistance = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(selfPosition, targetPosition, stepDistance);

        Vector3 direction = targetPosition - selfPosition;
        if (direction != Vector3.zero)

            transform.rotation = Quaternion.LookRotation(direction);

    }

}
