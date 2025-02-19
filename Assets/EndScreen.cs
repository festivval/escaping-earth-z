using UnityEngine;

public class EndScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show() {
        gameObject.GetComponent<Canvas>().enabled = true;
        Debug.Log("sadge");
    }
}
