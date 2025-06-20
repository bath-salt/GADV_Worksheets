using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spacing = 2f;
    public int size = 4;
    public Vector3 origin = Vector3.zero;
    public float delayBeforeExplode = 2f;
    public float explosionPower = 1000f;
    public float explosionRadius = 10f;

    void Start()
    {
        // Spawn the stack of cubes
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                for (int z = 0; z < size; z++)
                {
                    Vector3 pos = origin + new Vector3(x, y, z) * spacing;
                    GameObject obj = Instantiate(cubePrefab, pos, Quaternion.identity);

                    // Ensure cube has Rigidbody
                    if (obj.GetComponent<Rigidbody>() == null)
                        obj.AddComponent<Rigidbody>();
                }
            }
        }

        // Trigger explosion after delay
        Invoke("Explode", delayBeforeExplode);
    }

    void Explode()
    {
        Debug.Log("Explosion triggered!");
        Collider[] colliders = Physics.OverlapSphere(origin + Vector3.up * 2f, explosionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Debug.Log("Applying force to: " + rb.name);
                rb.AddExplosionForce(explosionPower, origin + Vector3.up * 2f, explosionRadius, 3f);
            }
        }
    }
}
