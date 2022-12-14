using UnityEngine;

public class Rays : MonoBehaviour
{
    Vector3 selfPos;
    Vector3 targetPos;
    float maxDistance;

    private void OnDrawGizmos()
    {
        
        selfPos = transform.position;
        Vector3 distance = targetPos - selfPos;
       if (distance.magnitude > maxDistance)
        {

        }


    }


}
