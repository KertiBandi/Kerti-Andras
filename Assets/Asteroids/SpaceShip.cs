using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] float acceleration;
    [SerializeField] KeyCode forwardButton = KeyCode.UpArrow;
    [SerializeField] float maxSpeed;

    [SerializeField] float angularSpeed = 90;
    [SerializeField] float drag = 0.3f;

    Vector3 velocity;


    private void FixedUpdate()
    {
        bool forward = Input.GetKey(forwardButton) || Input.GetKey(KeyCode.W);
        if (forward)
        {
            Vector3 direction = transform.up;
            velocity += direction * acceleration * Time.fixedDeltaTime;

        
        }

        float currentSpeed = velocity.magnitude;

        if(currentSpeed>maxSpeed)
        {
            velocity.Normalize();
            velocity *= maxSpeed;
        }


        transform.position += velocity * Time.fixedDeltaTime;

        // forgás
        float rotationInput = Input.GetAxis("Horizontal");

        transform.Rotate(0, 0, -rotationInput*angularSpeed*Time.fixedDeltaTime);

        //Lassulás
        velocity *= 1 - (drag * Time.fixedDeltaTime);

    }


}
