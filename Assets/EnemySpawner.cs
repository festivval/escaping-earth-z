using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;
    public float minSpawnTime = 5.0f;
    public float maxSpawnTime = 15.0f;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = minSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0) {
            GameObject temp = Instantiate(prefab, new Vector2(randX(),randY()), Quaternion.identity);
            temp.SetActive(true);
            timer = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    // hard coded constants because ladidah who needs good coding practices
    private float randX() {
        return Random.Range(-10f,10f);
    }

    private float randY() {
        return Random.Range(-4f,4f);
    }
}
