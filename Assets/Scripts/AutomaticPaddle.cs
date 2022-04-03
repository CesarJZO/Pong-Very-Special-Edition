using UnityEngine;

public class AutomaticPaddle : MonoBehaviour
{
    // TODO: Add delay to the paddle, start following after the player hit the ball, random speed
    [SerializeField] GameObject ball;
    [SerializeField] float height;
    [SerializeField] Side side;
    Vector2 bounds;
    private void Awake()
    {
        bounds = new Vector2();
    }
    private void Update()
    {
        transform.position = new Vector2(transform.position.x, ball.transform.position.y);

        bounds.x = transform.position.x;
        bounds.y = Mathf.Clamp(transform.position.y, height / -2, height / 2);
        transform.position = bounds;
    }

    public void SetPosition(float horizontal)
    {
        Vector3 newPosition = transform.position;
        newPosition.x = side == Side.Left ? -horizontal + 18.5f : horizontal - 18.5f;
        transform.position = newPosition;
    }
}
