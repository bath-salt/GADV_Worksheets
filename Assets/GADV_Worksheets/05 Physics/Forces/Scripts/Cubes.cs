//using UnityEngine;

//public class Cubes : MonoBehaviour
//{
//    [SerializeField]
//    private GameObject spawnedcube;

//    float spacing = 1f;
//    void Start()
//    {
//        GameObject player = GameObject.FindWithTag("Player");

//        StackCubes(Vector3.zero, 4, 4, 4);
//    }

//    void StackCubes(Vector3 pos, int nx, int ny, int nz)
//    {
//        for (int i = 0; i < nx; i++)
//        {
//            for (int j = 0; j < ny; j++)
//            {
//                for (int k = 0; k < nz; k++)
//                {
//                    Vector3 cubePos = pos + new Vector3(i * spacing, j * spacing, k * spacing);
//                    Instantiate(cube, cubePos, Quaternion.identity);
//                    if (!cube.GetComponent<Rigidbody>())
//                        cube.AddComponent<Rigidbody>();
//                }
//            }
//        }
//    }
//    void Update()
//    {

//    }
//}

using UnityEngine;

public class Cubes : MonoBehaviour
{
    [SerializeField] private GameObject cube; // Assign in Inspector
    [SerializeField] private float spacing = 1f;

    void Start()
    {
        
        StackCubes(Vector3.zero, 4, 4, 4);
    }

    void StackCubes(Vector3 pos, int nx, int ny, int nz)
    {
        for (int i = 0; i < nx; i++)
        {
            for (int j = 0; j < ny; j++)
            {
                for (int k = 0; k < nz; k++)
                {
                    Vector3 cubePos = pos + new Vector3(i * spacing, j * spacing, k * spacing);
                    GameObject spawnedCube = Instantiate(cube, cubePos, Quaternion.identity);
                    Rigidbody rb = spawnedCube.GetComponent<Rigidbody>();
                    if (rb == null)
                        rb = spawnedCube.AddComponent<Rigidbody>();

                    // Make sure physics will work as expected
                    rb.isKinematic = false;
                    rb.useGravity = true;
                    rb.mass = 1f;
                    rb.interpolation = RigidbodyInterpolation.Interpolate;
                    rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                }
            }
        }
    }
}
