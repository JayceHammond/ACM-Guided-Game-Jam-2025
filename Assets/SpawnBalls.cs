using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject ballPrefab;

    private float spawnTime = 2f;
    private float currentTime;
    public float spawnRange;

    private Transform spawnArea;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnArea = transform;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= spawnTime)
        {
            transform.position = new Vector3(transform.position.x + Random.Range(-spawnRange, spawnRange), spawnArea.position.y, spawnArea.position.z);
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
            currentTime = 0;
        }
    }
}
