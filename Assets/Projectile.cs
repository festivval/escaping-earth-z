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
        rb.linearVelocity = transform.right * 20;

        expirationTime -= Time.deltaTime;
        if(expirationTime <= 0)
            Destroy(gameObject);
    }
}
