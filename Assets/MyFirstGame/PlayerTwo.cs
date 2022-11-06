using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        bool isRightPressed = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool isLeftPressed = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool isUpPressed = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool isDownPressed = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        bool isSpacePressed = Input.GetKey(KeyCode.Space);

        float x = 0;
        if (isRightPressed)
        {
            x += 1;
        }
        if (isLeftPressed)
        {
            x -= 1;
        }

        float z = isUpPressed ? 1 : (isDownPressed ? -1 : 0);




        float y = 0;
        if (isSpacePressed)
        {
            y += 1;

        }

        Vector3 direction = new Vector3(x, 0, z);
        direction.Normalize(); // keresztbe mozg�s sebess�g�t normaliz�ltuk



        Vector3 velocity = direction * speed;






        transform.position += velocity * Time.deltaTime; // time.deltaTime kell hogy egyenletes legyen a mozg�s minden g�pen

        // egyenletes v�ltoz�s el�r�s�re haszn�ljuk a time,deltatime-ot


        if (direction != Vector3.zero)

            transform.rotation = Quaternion.LookRotation(direction);


        Vector3 jump = new Vector3(0, y, 0);
        Vector3 jumpSpeed = jump * speed;

        transform.position += jumpSpeed * Time.deltaTime;

    }
}

