using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    Vector2 direction;
    Rigidbody2D rb;
    void Awake()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y);
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}
