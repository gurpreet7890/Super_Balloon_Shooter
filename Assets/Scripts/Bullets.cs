using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletDamage = 10f;

    Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        Vector2 force = transform.right * bulletSpeed;
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    private void Update()
    {
        // Moves the bullet forward
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}