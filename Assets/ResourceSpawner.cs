using UnityEngine;

public class ResourceSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float minSpawnTime = 3.0f;
    public float maxSpawnTime = 7.0f;
    private int numActive;
    private float timer;

    public Display rd;
    public int numCollected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numActive = 0;
        numCollected = 0;
        timer = minSpawnTime;
        rd.update(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(numActive < 3) {
            timer -= Time.deltaTime;
            if(timer <= 0) {
                GameObject temp = Instantiate(prefab, new Vector2(randX(),randY()), Quaternion.identity);
                temp.SetActive(true);
                numActive++;
                timer = Random.Range(minSpawnTime, maxSpawnTime);
            }
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
        numActive--;
        numCollected++;
        rd.update(numCollected);

    }
}
