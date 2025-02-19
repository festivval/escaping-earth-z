using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private bool damage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        damage = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(damage)
            playerHealth.hurt();
    }

    private void OnCollisionEnter2D(Collision2D c) {
        if(c.gameObject.tag == "Player")
	    damage = true;
    }
    private void OnCollisionExit2D(Collision2D c) {
        if(c.gameObject.tag == "Player")
	    damage = false;
    }
}
