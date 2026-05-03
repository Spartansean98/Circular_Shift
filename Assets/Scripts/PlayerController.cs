using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    InputAction jumpAction;
    Rigidbody2D rigidbody;
    [SerializeField]SpriteRenderer renderer;
    public LayerMask groundLayer;
    bool doubleJump;
    public int jumpHeight = 2;
    public int movementSpeed = 5;
    public bool upsidedownWorld;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(SceneManager.GetActiveScene().buildIndex!=0||SceneManager.GetActiveScene().buildIndex!=11||SceneManager.GetActiveScene().buildIndex!=12)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void Movement()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        // if(upsidedownWorld)
        // {
        //     moveValue = new Vector2(-moveValue.x,moveValue.y);
        // }
        if(moveValue.x<0)
        {
            renderer.flipX = true;
        }
        else if(moveValue.x>0)
        {
            renderer.flipX = false;
        }
        rigidbody.linearVelocity =new Vector2(moveValue.x*movementSpeed, rigidbody.linearVelocity.y);
        if(IsGrounded()&&!jumpAction.IsPressed())
        {
            doubleJump = false;
        }
        if(jumpAction.IsPressed()){
        if(IsGrounded()||doubleJump)
        {
            rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x,jumpHeight);
            doubleJump = !doubleJump;
        }
        }
    }
    
    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(transform.position, 0.5f, groundLayer);
    }

    public void SpringJump(int boost)
    {
        rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x,boost);

    }
}
