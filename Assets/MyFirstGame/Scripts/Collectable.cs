using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] int value = 1;
    [SerializeField] Bounds teleportBounds; // ezzel kiv�gunk egy szeletet a t�rb�l

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
        float randomY = Random.Range(min.y, max.y); // f-n�lk�l int �rt�ket adna
        float randomZ = Random.Range(min.z, max.z);

        Vector3 randomPoint = new Vector3(randomX, randomY, randomZ);
        transform.position = randomPoint;

    }

}
