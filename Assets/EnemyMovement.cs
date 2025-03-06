using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float maxSpeed = 10f;
    //public float minSpeed = -1f;
    private float acceleration = 2f;
    public PlayerMovement player;
    public Rigidbody2D rb;
    Vector2 myPos;

    private EnemyHealthBar healthBar;
    public int maxHealth = 10;
    public int health;

    void Start() {
        myPos = new Vector2(0,0);
        health = maxHealth;
        healthBar = GetComponentInChildren<EnemyHealthBar>();
    }

    void FixedUpdate() {
        myPos.x = transform.position.x;
        myPos.y = transform.position.y;

        rb.AddForce((player.pos - myPos).normalized * acceleration);
        if(rb.linearVelocity.magnitude > maxSpeed)
            rb.linearVelocity = (player.pos - myPos).normalized * acceleration;
    }

    public void hurt() {
        health--;
        healthBar.updateHealth(1.0f*health/maxHealth);
        rb.linearVelocity = -(player.pos - myPos).normalized * acceleration * 0.5f;
        if(health <= 0)
            Destroy(gameObject);
    }
}
