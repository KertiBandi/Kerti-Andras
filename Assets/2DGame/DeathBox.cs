using UnityEngine;

public class DeathBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("DEATH!!!");
        //Destroy(collision.gameObject);
        HealthObject healthObject = collision.gameObject.GetComponent<HealthObject>();
        if (healthObject != null)
        {
            healthObject.Kill();
        }

        


    }
}
