using UnityEngine;

public class explosion : MonoBehaviour
{
    [SerializeField] private float _triggerForce = 1f;
    [SerializeField] private float _explosionRadius = 5;
    [SerializeField] private float _explosionForce = 50;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > _triggerForce)
        {
            var surroundingObjects = Physics.OverlapSphere(transform.position, _explosionRadius);

            foreach (var obj in surroundingObjects)
            {
                var rb = obj.GetComponent<Rigidbody>();
                if (rb == null) continue;

                rb.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
            }
        }
    }
}
