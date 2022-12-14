using UnityEngine;

public class lifeBar : MonoBehaviour
{
    [SerializeField] float maxLife = 100f ;
    [SerializeField] float currentHealt = 50f;
    [SerializeField] float wideness = 1;
    [SerializeField] Vector3 lifebarOffSet = Vector3.up;
    [SerializeField] Color color1, color2;

    private void OnDrawGizmos()
    {


    }


}
