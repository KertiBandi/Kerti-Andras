using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float stepDistance;
    Vector3 target;

    private void Start()
    {
        target = transform.position;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            target += Vector3.up* stepDistance;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            target += Vector3.down * stepDistance;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            target += Vector3.right * stepDistance;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            target += Vector3.left * stepDistance;

        Vector3 selfPosition = transform.position;
        
            transform.position = Vector3.MoveTowards(selfPosition,target,speed*Time.deltaTime);


    }
}
