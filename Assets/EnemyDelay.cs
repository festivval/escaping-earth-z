using UnityEngine;

public class EnemyDelay : MonoBehaviour
{
    private float delay = 1.5f;
    public GameObject prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if(delay <= 0) {
            GameObject temp = Instantiate(prefab, transform.position, Quaternion.identity);
            temp.SetActive(true);
            Destroy(gameObject);
        }
    }
}
