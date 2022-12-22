using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed;
    [SerializeField] Animator anim;

    private void OnValidate()
    {
        if(anim == null)
        {
            anim = GetComponent<Animator>();
        }
    }

    void Update()
    {
        bool isRightPressed = Input.GetKey(KeyCode.RightArrow) ;
        bool isLeftPressed = Input.GetKey(KeyCode.LeftArrow);
        bool isUpPressed = Input.GetKey(KeyCode.UpArrow);
        bool isDownPressed = Input.GetKey(KeyCode.DownArrow);


        float x = 0;
        if(isRightPressed)
        {
            x += 1;
        }
        if (isLeftPressed)
        {
            x -= 1;
        }

        float  z = isUpPressed ? 1 : (isDownPressed ? -1 : 0);



        Vector3 direction = new Vector3(x,0, z);
        direction.Normalize(); // keresztbe mozgás sebességét normalizáltuk



        Vector3 velocity = direction * speed;

        bool isMoving = velocity != Vector3.zero;
        anim.SetBool("IsRunning",isMoving);




        transform.position += velocity * Time.deltaTime; // time.deltaTime kell hogy egyenletes legyen a mozgás minden gépen

        // egyenletes változás elérésére használjuk a time,deltatime-ot


        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Quaternion currentRotation = transform.rotation;

            float maxStepInAngle = angularSpeed * Time.deltaTime;

            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, maxStepInAngle);

        }

    }
}
