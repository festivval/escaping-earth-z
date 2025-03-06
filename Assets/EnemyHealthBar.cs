using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public float maxWidth = 20f;
    private Vector2 scale;

    void Start() {
        scale = new Vector2(0, 2);
        transform.localScale = scale;
    }

    public void updateHealth(float percent) {
        scale.x = percent*maxWidth;
        transform.localScale = scale;
    }
}
