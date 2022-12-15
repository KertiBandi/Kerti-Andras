using UnityEngine;
enum ShootingPattern { First, Sequence, Random, PingPong }


public class Shooter : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform startPoint;
    [SerializeField] GameObject[] bullets;
    [SerializeField] KeyCode key = KeyCode.LeftControl;

    [SerializeField] ShootingPattern pattern;

    int number = 0;
    

    private void Update()
    {
        
        if (Input.GetKeyDown(key))
        {
            int i;
            if (pattern == ShootingPattern.First)
                i = 0;
            else if (pattern == ShootingPattern.Sequence)
                i=number;

            else if (pattern == ShootingPattern.Random)
                i = Random.Range(0, bullets.Length);
            else
                i = 0;




            GameObject newBullet = Instantiate(bullets[i]);
            newBullet.transform.position = startPoint.position;

            Vector2 velocity = speed * transform.right;

            Bullet b = newBullet.GetComponent<Bullet>();
            b.SetVelocity(velocity);

            number++;
            if (number >=bullets.Length)
            {
                number = 0;
            }


        }
        



    }





}
