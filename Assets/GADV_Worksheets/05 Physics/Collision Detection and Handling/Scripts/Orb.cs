using UnityEngine;

public class Orb : MonoBehaviour
{
    public float impulseForce = 10f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * impulseForce, ForceMode.Impulse);
        }
    }
}
