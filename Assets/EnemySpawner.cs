using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(prefab, new Vector2(0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
