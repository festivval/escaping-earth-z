using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    private PlayerMovement player;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    void FixedUpdate() {
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y);
        rb.linearVelocity = (player.pos - myPos).normalized * moveSpeed;
	Debug.Log("wow");
    }
}
