using UnityEngine;

public class Player2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpForce;
    [SerializeField] float horizontalSpeed;
    [SerializeField] int airJumpCount;

    bool isGrounded;
    int airJumpCountBudget;


    private void OnValidate()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // jump
        if((isGrounded || airJumpCountBudget>0) && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse); //force folyamatos erõ, impulse egyszeri
            if(!isGrounded)
            {
                airJumpCountBudget--;
            }

        }
        //movement
        float inputX = Input.GetAxis("Horizontal");
        //Debug.Log(inputX);

       
            Vector2 velocity = new Vector2(inputX * horizontalSpeed, rigidbody.velocity.y);
            rigidbody.velocity = velocity;
        
        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        airJumpCountBudget = airJumpCount;
        //Debug.Log("Collide" + collision.otherCollider.name);

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Debug.Log("Exit");
        isGrounded = false;
    }

    private void FixedUpdate() // a fizika ebben hajtódik végre,nem állandóan, hanem fix idõközönként
    {
        
    }
}
