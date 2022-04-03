using UnityEngine;
using UnityEngine.Events;

public class ResponsivePlacer : MonoBehaviour
{
    public UnityEvent<float> OnSizeDefined;
    Camera mainCamera;
    float horizontal;
    BoxCollider2D[] colliders;

    void Awake()
    {
        mainCamera = Camera.main;
        colliders = GetComponents<BoxCollider2D>();
    }

    void Update()
    {
        horizontal = mainCamera.orthographicSize * mainCamera.aspect;
        foreach (BoxCollider2D c in colliders)
            c.size = new Vector2(horizontal * 2, c.size.y);
        OnSizeDefined?.Invoke(horizontal);
    }


}
