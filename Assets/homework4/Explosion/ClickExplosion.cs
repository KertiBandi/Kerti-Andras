using UnityEngine;

public class ClickExplosion : MonoBehaviour
{
    [SerializeField] Transform aimingPoint;
    [SerializeField] float maxExplosionForce;
    [SerializeField] float explosionRange;
    [SerializeField] float upwardModifier;



    private void Update()
    {
        Vector3 clickPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(clickPosition);

        bool isHit = Physics.Raycast(ray, out RaycastHit hitInfo);

        if(isHit)
        {
           // Debug.Log($"HIT: {hitInfo.collider.name}");
            aimingPoint.position = hitInfo.point;


        }
        else
        {
            aimingPoint.position = Vector3.up * 1000; //elt�ntetem a c�lz� g�mb�t
        }

        bool click = Input.GetMouseButtonDown(0);

        if (isHit && click)
        {
            Rigidbody[] rbs = FindObjectsOfType<Rigidbody>(); // ez egy t�mb
            for (int i = 0; i < rbs.Length; i++)
            {
                Rigidbody rb = rbs[i];

                rb.AddExplosionForce(maxExplosionForce,hitInfo.point,explosionRange);
            }
            aimingPoint.GetComponent<ParticleSystem>().Play();
        }



    }
}
