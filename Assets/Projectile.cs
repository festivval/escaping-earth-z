using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 5.0f;
    public float expirationTime = 50;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        expirationTime -= Time.deltaTime;
        if(expirationTime <= 0)
            Destroy(gameObject);
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime * projectileSpeed);
        
    }
}
