using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] int value = 1;
    [SerializeField] Bounds teleportBounds; // ezzel kivágunk egy szeletet a térbõl

    public int GetValue()
    { 
        return value;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(teleportBounds.center, teleportBounds.size);
    }

   public void Teleport()
    {
        Vector3 min = teleportBounds.min;
        Vector3 max = teleportBounds.max;
        float randomX = Random.Range(min.x, max.x);
        float randomY = Random.Range(min.y, max.y); // f-nélkül int értéket adna
        float randomZ = Random.Range(min.z, max.z);

        Vector3 randomPoint = new Vector3(randomX, randomY, randomZ);
        transform.position = randomPoint;

    }

}
