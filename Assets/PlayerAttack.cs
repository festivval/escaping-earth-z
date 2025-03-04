using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Vector3 right = new Vector3(0,0,0);
    private Vector3 up = new Vector3(0,0,90);
    private Vector3 left = new Vector3(0,0,180);
    private Vector3 down = new Vector3(0,0,-90);

    public PlayerMovement pm;
    public GameObject prefab;

    public static float cooldown = 0.35f;
    private float cooldownTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(cooldownTimer > 0)
            cooldownTimer -= Time.deltaTime;
        
        if(Input.GetKeyDown("space") && cooldownTimer <= 0) {
            cooldownTimer = cooldown;
            GameObject temp = Instantiate(prefab, transform.position, transform.rotation);
            temp.SetActive(true);
        }

        if(pm.movement.x > 0f) {
            transform.eulerAngles = right;
        }
        else if(pm.movement.x < 0f) {
            transform.eulerAngles = left;
        }
        else if(pm.movement.y > 0f) {
            transform.eulerAngles = up;
        }
        else if(pm.movement.y < 0f) {
            transform.eulerAngles = down;
        }
    }
}
