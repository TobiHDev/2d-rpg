using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        myRigidbody.linearVelocity = new Vector2(moveSpeed, 0f);
    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D other)
    {
            moveSpeed = -moveSpeed;
            transform.localScale = new Vector2(-Mathf.Sign(myRigidbody.linearVelocity.x), 1f);
    }
}
