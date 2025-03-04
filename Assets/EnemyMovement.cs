using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public PlayerMovement player;
    public Rigidbody2D rb;

    void Start() {
    }

    void FixedUpdate() {
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y);
        rb.linearVelocity = (player.pos - myPos).normalized * moveSpeed;
    }
}
