using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speedMultiplier;
    [SerializeField] Transform leftPaddle;
    [SerializeField] Transform rightPaddle;
    float speed;
    Vector2 direction;
    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        speed = Vector2.Distance(leftPaddle.position, rightPaddle.position);
        SetRandomDirection();
        rb.AddForce(direction * speed * speedMultiplier, ForceMode2D.Impulse);
    }

    void SetRandomDirection()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y).normalized;
    }
}
