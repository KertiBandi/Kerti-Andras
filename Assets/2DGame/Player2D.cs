using UnityEngine;

public class Player2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] HealthObject healthObject;

    [SerializeField] float jumpForce;
    [SerializeField] float horizontalSpeed;
    [SerializeField] int airJumpCount;


    bool isGrounded;
    int airJumpCountBudget;

    JumpMultiplier jumpPlatform;


    private void OnValidate()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        healthObject = GetComponent<HealthObject>();
    }

    void Update()
    {
        if (healthObject != null && healthObject.IsDead())
            return;


        // jump
        if ((isGrounded || airJumpCountBudget > 0) && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;
            Vector2 jump = Vector2.up * jumpForce;

            if (jumpPlatform != null)
            {
                jump *= jumpPlatform.multiplier;
            }


            rigidbody.AddForce(jump, ForceMode2D.Impulse); //force folyamatos erõ, impulse egyszeri
            if (!isGrounded)
            {
                airJumpCountBudget--;
            }

        }
        //movement
        float inputX = Input.GetAxis("Horizontal");

        if (inputX>0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (inputX<0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }



        //Debug.Log(inputX);
        /*if(inputX !=0)
        {
            float direction = Mathf.Sign(inputX);
            Vector3 scale = transform.localScale;
            transform.localScale = new Vector3(direction*Mathf.Abs(scale.x), scale.y,scale.z);
        }*/

        Vector2 velocity = new Vector2(inputX * horizontalSpeed, rigidbody.velocity.y);
        rigidbody.velocity = velocity;




    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        airJumpCountBudget = airJumpCount;
        //Debug.Log("Collide" + collision.otherCollider.name);
        jumpPlatform =
            collision.gameObject.GetComponent<JumpMultiplier>();

       /* if (platform != null) // null - 0 érték, csak bizonyos változók vehetik fel
        {
            //Debug.Log("Collided: Jump multiplier");
            //isOnJumpPlatform = true;
            float mult = platform.multiplier;

        }*/


    }

    private void OnCollisionStay2D(Collision2D collision)
    {




    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        // Debug.Log("Exit");
        isGrounded = false;
        //isOnJumpPlatform = false;
        jumpPlatform = null;
    }

    private void FixedUpdate() // a fizika ebben hajtódik végre,nem állandóan, hanem fix idõközönként
    {
        if (healthObject != null && healthObject.IsDead())
            return;
    }
}
