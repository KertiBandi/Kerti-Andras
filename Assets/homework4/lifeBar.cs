using UnityEngine;

public class lifeBar : MonoBehaviour
{
    [SerializeField] Vector3 maxLife;
    [SerializeField] Vector3 minLife;
    [SerializeField] Vector3 currentHealt;
    [SerializeField] float wideness;
    [SerializeField] Color color1, color2;

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(minLife, currentHealt);
        Gizmos.color = color1;
        Gizmos.DrawLine(currentHealt, maxLife);
        Gizmos.color = color2;

    }


}
