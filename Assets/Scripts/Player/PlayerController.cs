using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float moveX;

    public float moveSpeed = 3;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb.linearVelocityX = moveX * moveSpeed;
    }
}
