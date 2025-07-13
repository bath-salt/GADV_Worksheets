using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public int maxAsteroids = 10; // Public variable for max asteroid count

    private int currentAsteroidCount = 0;

    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    IEnumerator SpawnAsteroids()
    {
        while (currentAsteroidCount < maxAsteroids)
        {
            Vector2 screenPosition = new Vector2(
                Random.Range(0f, Screen.width),
                Random.Range(0f, Screen.height));

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(
                new Vector3(screenPosition.x, screenPosition.y, 10f));

            Instantiate(asteroidPrefab, worldPosition, Quaternion.identity);
            currentAsteroidCount++;

            yield return new WaitForSeconds(0.5f);
        }
    }
}
