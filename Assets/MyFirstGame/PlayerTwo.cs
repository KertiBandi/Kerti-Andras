using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float turnSpeed;
    [SerializeField] float jumpHeight;

    void Update()
    {
        bool isRightPressed = Input.GetKey(KeyCode.D);
        bool isLeftPressed = Input.GetKey(KeyCode.A);
        bool isUpPressed = Input.GetKey(KeyCode.W);
        bool isDownPressed = Input.GetKey(KeyCode.S);
        bool isSpacePressed = Input.GetKey(KeyCode.Space);


       


         if (isRightPressed)
         {
             transform.Rotate(Vector3.up, (turnSpeed * Time.deltaTime));
         }

         if (isLeftPressed)
         {
             transform.Rotate(Vector3.up, (-turnSpeed * Time.deltaTime));
         }


        
        //Quaternion q = transform.rotation;
        Vector3 direction = transform.forward;

     

        //Vector3 newForward = Quaternion.Euler(0, angle, 0) * transform.forward;

        if (isUpPressed)
        {

            transform.position += direction * speed * Time.deltaTime;
        }
        if (isDownPressed)
        {
            transform.position -= direction * speed * Time.deltaTime;
        }


        if (isSpacePressed)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpHeight*Time.deltaTime, 0);
        }

       // float z = isUpPressed ? 1 : (isDownPressed ? -1 : 0);




        /*  float y = 0;
          if (isSpacePressed)
          {
              y += 1;

          }*/






        /*  Vector3 direction = new Vector3(x, 0, z);
          direction.Normalize(); // keresztbe mozgás sebességét normalizáltuk



          Vector3 velocity = direction * speed;






          transform.position += velocity * Time.deltaTime; // time.deltaTime kell hogy egyenletes legyen a mozgás minden gépen

          // egyenletes változás elérésére használjuk a time,deltatime-ot


          if (direction != Vector3.zero)

              transform.rotation = Quaternion.LookRotation(direction);


          Vector3 jump = new Vector3(0, y, 0);
          Vector3 jumpSpeed = jump * speed;

          transform.position += jumpSpeed * Time.deltaTime; 
        */

    }
}

