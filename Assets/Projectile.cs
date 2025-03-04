using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float expirationTime = 5.0f;

    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        rb.linearVelocity = transform.right * 12;

        expirationTime -= Time.deltaTime;
        if(expirationTime <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy") {
            other.gameObject.GetComponent<EnemyMovement>().hurt();
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Wall")
            Destroy(gameObject);
    }
}
