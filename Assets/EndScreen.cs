using UnityEngine;
using UnityEngine.UI;

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
        GetComponentInChildren<Text>().text = "Game Over!\nScore: " + (GameObject.FindWithTag("ResourceSpawner").GetComponent<ResourceSpawner>().numCollected);
;
        Time.timeScale = 0;
    }
}
