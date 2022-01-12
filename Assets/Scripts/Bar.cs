using UnityEngine;

public class Bar : MonoBehaviour
{
    public float speed;
    public int playerIndex;
    string verticalInput;
    float screenWidth;
    Rigidbody2D rb;
    Vector2 velocity;
    void Awake()
    {
        verticalInput = $"Vertical P{playerIndex}";
        // TODO Place bars on a position relative to the screen
        // screenWidth = Camera.main.orthographicSize;
        // Debug.Log(Camera.main.scaledPixelWidth);
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2();
    }

    void FixedUpdate()
    {
        velocity.y = Input.GetAxis(verticalInput);
        if (IsTouching)
            rb.velocity = Vector2.zero;
        else
            rb.velocity = velocity * speed;
    }

    bool IsTouching =>
        transform.position.y >=  34 && Input.GetAxis(verticalInput) > 0 ||
        transform.position.y <= -34 && Input.GetAxis(verticalInput) < 0;
}
