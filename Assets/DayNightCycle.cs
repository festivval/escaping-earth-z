using UnityEngine;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour
{
    private Color startColor = new Color32(255,252,204,10);
    private Color endColor = new Color32(0,0,0,100);

    public float lengthOfDay = 5f;
    private float time = 0f;
    Image img;
    Color color;

    public bool danger = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = GetComponent<Image>();
        color = startColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(time < lengthOfDay)
            time += Time.deltaTime;
        else
            danger = true;
        color = Color.Lerp(startColor, endColor, Mathf.PingPong(time/lengthOfDay,1));
        img.color = color;
    }
}
