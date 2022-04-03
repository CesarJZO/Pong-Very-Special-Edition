using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    [SerializeField] float smoothTime;
    [SerializeField] float height;
    [SerializeField] Side side;
    public float speed;
    PlayerInput playerInput;
    InputAction moveAction;
    Rigidbody2D rb;
    Vector2 direction;
    private Vector2 velocity;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
        // TODO Place bars on a position relative to the screen
        // screenWidth = Camera.main.orthographicSize;
        // Debug.Log(Camera.main.scaledPixelWidth);
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2();
    }

    void FixedUpdate()
    {
        Vector2 target = (moveAction.ReadValue<Vector2>() * speed) + (Vector2)transform.position;
        direction = Vector2.SmoothDamp(transform.position, target, ref velocity, smoothTime);
        direction.y = Mathf.Clamp(direction.y, height / -2, height / 2);
        rb.MovePosition(direction);
    }

    public void SetPosition(float horizontal)
    {
        Vector3 newPosition = transform.position;
        newPosition.x = side == Side.Left ? -horizontal + 18.5f : horizontal - 18.5f;
        transform.position = newPosition;
    }
}
