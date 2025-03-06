using UnityEngine;

public class Resource1 : MonoBehaviour
{

    public float startTime = 1.5f;
    private float time;
    private bool collecting;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collecting = false;
        time = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(collecting)
            time -= Time.deltaTime;
        if(time <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if(c.gameObject.tag == "Player")
	    collecting = true;
    }
    private void OnTriggerExit2D(Collider2D c) {
        if(c.gameObject.tag == "Player")
	    collecting = false;
    }
}
