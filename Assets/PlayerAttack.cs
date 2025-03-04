using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Vector2 right = new Vector2(0.25f, 0);
    private Vector2 left = new Vector2(-0.25f, 0);
    private Vector3 horizontal = new Vector3(0,0,0);
    private Vector2 up = new Vector2(0,0.25f);
    private Vector2 down = new Vector2(0,-0.25f);
    private Vector3 vertical = new Vector3(0,0,90);

    private PlayerMovement pm;

    private BoxCollider2D hitbox;
    public float cooldown = 0.2f;
    private float cooldownTimer = 0;

    public float hitDuration = 0.1f;
    private float hitTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pm = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        hitbox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(cooldownTimer > 0)
            cooldownTimer -= Time.deltaTime;
        if(hitTimer > 0)
            hitTimer -= Time.deltaTime;

        if(Input.GetKeyDown("space") && cooldownTimer == 0) {
            cooldownTimer = cooldown;
            hitTimer = hitDuration;
            hitbox.enabled = true;
        }

        if(pm.movement.x > 0f) {
            transform.localPosition = right;
            transform.eulerAngles = horizontal;
        }
        else if(pm.movement.x < 0f) {
            transform.localPosition = left;
            transform.eulerAngles = horizontal;
        }
        else if(pm.movement.y > 0f) {
            transform.localPosition = up;
            transform.eulerAngles = vertical;
        }
        else if(pm.movement.y < 0f) {
            transform.localPosition = down;
            transform.eulerAngles = vertical;
        }
    }
}
