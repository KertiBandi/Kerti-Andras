using UnityEngine;

public class LerpPractice : MonoBehaviour
{
    [SerializeField] Vector3 point1, point2;
    [SerializeField] Color color1, color2;
    [SerializeField, Min(2)] int segment = 10;

    private void OnDrawGizmos()
    {

        float fraction = 1f / segment;
        for (int i = 0; i < segment; i++)
        {
            float colorRate = (float)i / (segment - 1);
            Color color = Color.Lerp(color1, color2, colorRate);
            Vector3 startPoint = Vector3.Lerp(point1, point2, i * fraction);
            Vector3 endPoint = Vector3.Lerp(point1, point2, (i + 1) * fraction);
            Gizmos.color = color;
            Gizmos.DrawLine(startPoint, endPoint);



        }


    }
}
