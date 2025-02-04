using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int max = 10;
    public float iFrames = 0.2f;
    public float iFramesTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = max;
        iFramesTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(iFramesTimer > 0)
            iFramesTimer -= Time.deltaTime;
    }

    public void hurt() {
        if(iFramesTimer <= 0) {
           iFramesTimer = iFrames;
           health--;
        }
        if(health <= 0)
            Destroy(gameObject);
    }
}
