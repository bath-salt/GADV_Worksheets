using UnityEngine;

public class CosmicCube : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Orb")
        {
            rend.material.color = Color.green;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Orb")
        {
            rend.material.color = Color.red;
        }
    }
}
