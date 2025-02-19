using UnityEngine;

public class ResourceSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float minSpawnTime = 3.0f;
    public float maxSpawnTime = 7.0f;
    private int numResources;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numResources = 0;
        timer = minSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0 && numResources < 3) {
            GameObject temp = Instantiate(prefab, new Vector2(randX(),randY()), Quaternion.identity);
            temp.SetActive(true);
            numResources++;
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

    public void remove() {
        numResources--;
    }
}
