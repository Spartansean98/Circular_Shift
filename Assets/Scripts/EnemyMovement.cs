using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool goingTarget1 = true;
    public Transform target1;
    public Transform target2;
    SpriteRenderer renderer;
    public int speed;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(goingTarget1)
        {
            MoveToward(target1);
        }
        else
        {
            MoveToward(target2);
        }
    }

    public void MoveToward(Transform target)
    {
        transform.position = Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);

    }

    public void SwapTarget()
    {
        goingTarget1 =!goingTarget1;
        renderer.flipX =!renderer.flipX;

    }
}
