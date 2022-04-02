using UnityEngine;

public class AutomaticPaddle : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] float height;
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
}