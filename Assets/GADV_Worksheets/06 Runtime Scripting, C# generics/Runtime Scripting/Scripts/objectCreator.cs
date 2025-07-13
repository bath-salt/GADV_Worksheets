using UnityEngine;

public class objectCreator : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public int numberOfAsteroids = 10;
    public Vector2 spawnRangeX = new Vector2(-5f, 5f);
    public Vector2 spawnRangeY = new Vector2(-3f, 3f);

    void Start()
    {
        SpawnAsteroids();
    }

    void SpawnAsteroids()
    {
        for(int i = 0; i < numberOfAsteroids; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(spawnRangeX.x, spawnRangeX.y), Random.Range(spawnRangeY.x, spawnRangeY.y), 0f);

            GameObject asteroid = Instantiate(asteroidPrefab,randomPosition, Quaternion.identity);

            asteroid.AddComponent<Rigidbody2D>();

            Destroy(asteroid, Random.Range(0f, 5f));
        }
    }
}
