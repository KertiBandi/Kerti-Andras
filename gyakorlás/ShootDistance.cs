using UnityEngine;

public class ShootDistance : MonoBehaviour
{
    [SerializeField] float minRange, maxRange;
    [SerializeField] float rangeMultiplier;
    [SerializeField] float enemyDistance;

    [SerializeField] bool canHitEnemy;
    [SerializeField] string text;

    void OnValidate()
    {
       

        canHitEnemy = enemyDistance > minRange && enemyDistance <= rangeMultiplier * maxRange;

    }

}
