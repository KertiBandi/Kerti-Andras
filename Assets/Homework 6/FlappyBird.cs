using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    [SerializeField] float gravityForce;
    [SerializeField] float jumpForce;
    [SerializeField] float top;
    [SerializeField] float bottom;


    Vector3 falling;
    bool isPlaying = true;


    private void Update()
    {
        //gravity
        Vector3 direction = transform.up;

        

        if (isPlaying)
        {
            falling -= direction * gravityForce * Time.deltaTime;
            transform.position += falling * Time.deltaTime;
        }



        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isPlaying)
        {
            // falling = Vector3.zero;
            falling += direction * jumpForce;


        }

        float y = transform.position.y;
        if ((y < bottom || y > top)&& isPlaying)
        {
            falling = Vector3.zero;
            isPlaying = false;
            Debug.Log("Game Over");
        }

        if (!isPlaying && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = transform.position;
            pos.y = (top + bottom) / 2;
            transform.position = pos;
            isPlaying = true;

        } 



    }
}

