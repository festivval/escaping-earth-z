using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplay : MonoBehaviour
{
    private Text collected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collected = gameObject.GetComponent<Text>();
        updateText(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // called when player collects a resource
    public void updateText(int numCollected) {
        collected.text = ("Resources: " + numCollected.ToString());
    }
}
