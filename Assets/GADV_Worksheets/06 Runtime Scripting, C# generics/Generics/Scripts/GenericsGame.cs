using UnityEngine;
using System.Collections.Generic;

public class GenericsGame : MonoBehaviour
{
//    public Asteroid AsteroidPrefab;

//    void Start()
//    {
//        SpawnAsteroid(AsteroidPrefab, new Vector3(0, 0, 0));
//    }

//    public GameObject SpawnAsteroid(
//GameObject asteroidPrefab, Vector3 position)
//    {
//        // The non-generic approach, which returns a GameObject
//        GameObject clone = Instantiate(
//asteroidPrefab, position, Quaternion.identity);

//        // The generic approach, which returns the actual type 
//        // specified by <T>. Note that the prefab must have a 
//        // component of the specified type, e.g. ateroidPrefab must // have an Asteroid component (script) attached to it.
//        Asteroid clone = Instantiate<Asteroid>(asteroidPrefab);

//        Debug.Log("Spawned: " + clone.name);
//        return clone;
//    }
}
