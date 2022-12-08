using UnityEngine;

public class Collector : MonoBehaviour
{
    int collectedValue = 0;

    private void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.gameObject.GetComponent<Collectable>();


        if(collectable !=null)
        {
            collectedValue += collectable.GetValue();
            Debug.Log("Collected: "+collectedValue);
            collectable.Teleport();

        }


    }
}
