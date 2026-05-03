using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public bool isTarget1;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Enemy"))
        {

            collision.GetComponent<EnemyMovement>().SwapTarget();
        }
    }
}
