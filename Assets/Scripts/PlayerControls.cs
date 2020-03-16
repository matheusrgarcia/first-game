using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadious;
    public LayerMask whatIsGround;
    private bool onGround;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Current Velocity
        rb.velocity = new Vector2(2, rb.velocity.y);

        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadious, whatIsGround);

        if(Input.GetMouseButtonDown(0))
        {
            print("On ground?" + onGround);
        }

        // Why I can't get my onGround to work as expected? :/ not a code problem though
        if(Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 4);
        }
    }
}
