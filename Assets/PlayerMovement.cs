using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 pos;
    public Vector2 movement;
    private Rigidbody2D rb;

    void Start()
    {
        // Cache the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }

    void Update()
    {
        // Input handling
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right Arrow
        movement.y = Input.GetAxisRaw("Vertical");   // W/S or Up/Down Arrow
        pos = transform.position;
    }

    void FixedUpdate()
    {
        // Apply velocity to the Rigidbody2D
        rb.linearVelocity = movement * moveSpeed;
    }
}
