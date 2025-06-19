using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 30f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, rotationSpeed * Time.deltaTime * -1);
    }
}
