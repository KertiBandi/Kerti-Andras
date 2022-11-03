using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        bool isRightPressed = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool isLeftPressed = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool isUpPressed = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool isDownPressed = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);

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






        transform.position += velocity * Time.deltaTime; // time.deltaTime kell hogy egyenletes legyen a mozgás minden gépen

        // egyenletes változás elérésére használjuk a time,deltatime-ot


        if(direction != Vector3.zero)

        transform.rotation = Quaternion.LookRotation(direction);

    }
}
