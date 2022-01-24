using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    [SerializeField] float height;
    public float speed;

    PlayerInput playerInput;
    InputAction moveAction;
    Rigidbody2D rb;
    Vector2 bounds;
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
        // TODO Place bars on a position relative to the screen
        // screenWidth = Camera.main.orthographicSize;
        // Debug.Log(Camera.main.scaledPixelWidth);
        rb = GetComponent<Rigidbody2D>();
        bounds = new Vector2();
    }

    void FixedUpdate()
    {
        rb.velocity = moveAction.ReadValue<Vector2>() * speed;
        bounds.x = transform.position.x;
        bounds.y = Mathf.Clamp(transform.position.y, height / -2, height / 2);
        transform.position = bounds;
    }
}
