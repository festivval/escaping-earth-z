using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float moveSpeed = 2f;
    float t;
    Vector2 start, center, center2;

    void Start() {
        start = transform.position;
        center = new Vector2(2f, 2f);
        center2 = new Vector2(-2f, -2f);
    }

    void Update() {
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, center, step);

        if(transform.position.x == center.x && transform.position.y == center.y) {
            Vector2 temp = center;
            center = center2;
            center2 = temp;
        }
    }
}
