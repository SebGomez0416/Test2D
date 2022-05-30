using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement();
    }


    private void Movement()
    {
        Vector2 movement;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y= Input.GetAxisRaw("Vertical");
        
        rb.MovePosition(rb.position + movement*(speed* Time.fixedDeltaTime));
    }
    
    
}
