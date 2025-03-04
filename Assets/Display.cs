using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    private Text text;
    public string displayWords;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // called when player takes damage
    public void update(int amount) {
        text.text = (displayWords + amount.ToString());
    }
}
