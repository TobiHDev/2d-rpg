using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float bulletSpeed = 20f;
    Rigidbody2D myRigidbody;
    float xSpeed;
    PlayerMovement player;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindFirstObjectByType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.linearVelocity = new Vector2(xSpeed, 0f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 1f);
    }
}
