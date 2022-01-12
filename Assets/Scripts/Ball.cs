using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    Vector2 direction;
    Rigidbody2D rb;
    void Awake()
    {
        int x = 1;
        float y = Random.Range(-1, 1);
        direction = new Vector2(x, y);
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }

    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            Invoke("Start", 0);
        }
    }
}
