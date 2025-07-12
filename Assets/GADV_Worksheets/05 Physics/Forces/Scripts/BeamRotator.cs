using UnityEngine;

public class BeamRotator : MonoBehaviour
{
    public float torqueStrength = 50f; 
    public Vector3 torqueAxis = Vector3.up; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ApplyTorque(-torqueAxis); 
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            ApplyTorque(torqueAxis); 
        }
    }

    void ApplyTorque(Vector3 direction)
    {
        rb.AddTorque(direction.normalized * torqueStrength, ForceMode.Impulse);
    }
}
