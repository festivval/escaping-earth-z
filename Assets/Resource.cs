using UnityEngine;

public class Resource : MonoBehaviour
{
    private SpriteRenderer sr;

    public float startTime = 1.5f;
    private float time;
    private bool collecting;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collecting = false;
        sr = GetComponent<SpriteRenderer>();
        time = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(collecting)
            time -= Time.deltaTime;
            // taken from here: https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Color.Lerp.html
            sr.color = Color.Lerp(Color.white, Color.black, Mathf.PingPong((startTime-time)/startTime, 1));
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
