using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int max = 10;
    public float iFrames = 0.4f;
    private float iFramesTimer;
    public Display hd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = max;
        iFramesTimer = 0;
	hd.update(health);
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
           hd.update(health);
        }
        if(health <= 0) {
            hd.update(0);
            GameObject.FindWithTag("EndScreen").GetComponent<EndScreen>().show();
            Destroy(gameObject);
        }
    }
}
