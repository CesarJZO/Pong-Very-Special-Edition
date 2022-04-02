using UnityEngine;
using UnityEngine.UI;
public class ScoreRenderer : MonoBehaviour
{
    public Sprite[] numbers;
    Image image;
    void Awake()
    {
        image = GetComponent<Image>();
    }
    public void UpdateScore(int value)
    {
        if (value > 9) return;
        image.sprite = numbers[value];
    }
}
