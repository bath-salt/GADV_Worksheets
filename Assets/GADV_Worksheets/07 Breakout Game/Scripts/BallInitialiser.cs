using UnityEngine;

public class BallInitialiser : MonoBehaviour
{
    private Rigidbody2D MyRb { get; set; }

    public float speed = 500f;

    public void Awake()
    {
        MyRb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1f;

        MyRb.AddForce(force.normalized * speed);
    }
}
