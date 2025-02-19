using UnityEngine;

public class Resource : MonoBehaviour
{
    private float time = 3.0f;
    private bool collecting;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collecting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(collecting)
            time -= Time.deltaTime;
        if(time <= 0) {
            GameObject.FindWithTag("ResourceSpawner").GetComponent<ResourceSpawner>().remove();
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
