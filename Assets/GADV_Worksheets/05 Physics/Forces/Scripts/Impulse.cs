using UnityEngine;

public class SphereImpulseController : MonoBehaviour
{
    public float impulseStrength = 10f; // Set in Inspector

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ApplyImpulse(Vector3.forward); 
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ApplyImpulse(Vector3.back); 
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ApplyImpulse(Vector3.left); 
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ApplyImpulse(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            ApplyImpulse(Vector3.up); 
        }
    }

    void ApplyImpulse(Vector3 direction)
    {
        rb.AddForce(direction.normalized * impulseStrength, ForceMode.Impulse);
    }
}

