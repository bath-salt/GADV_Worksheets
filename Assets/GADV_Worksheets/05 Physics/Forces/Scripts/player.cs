using UnityEngine;
using System.Collections;
public class player : MonoBehaviour
{
    public float speed = 6.0f;
    public float rotateSpeed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    public float radius = 20.0f;
    public float power = 10000.0f;

    [SerializeField]
    private Transform exPos;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false;
        
    }

    
    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 explosionPos = exPos.position + Vector3.up * 1f; // Slightly above ground
            Debug.Log("Explosion at: " + explosionPos);

            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
            Debug.Log("Colliders found: " + colliders.Length);

            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    Debug.Log("Applying explosion force to: " + hit.name);
                    rb.AddExplosionForce(power, explosionPos, radius, 5.0f);
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButtonDown("Fire1"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        else
        {
            moveDirection = new Vector3(0, moveDirection.y, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection.x *= speed;
            moveDirection.z *= speed;
        }
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        CheckExplosion();
    }
}
