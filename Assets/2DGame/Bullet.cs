using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float lifeTime = 3;

    Vector2 velocity;
    float starTime;

    private void Start()
    {
        starTime = Time.time;
    }

    public void SetVelocity(Vector2 velocity)
    {
        this.velocity = velocity; //this, mindig az adott gameobjectre hivatkozunk


    }


    private void Update()
    {
        transform.position += (Vector3)velocity * Time.deltaTime;

        float age = Time.time - starTime;
        if(age> lifeTime)
        {
            Destroy(gameObject);
        }
    }


}
