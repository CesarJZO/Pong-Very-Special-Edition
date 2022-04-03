using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class Edge : MonoBehaviour
{
    [SerializeField] float disableTime;
    [SerializeField] Side side;
    public UnityEvent<int> OnMissBall;
    int playerScore;

    void OnTriggerExit2D(Collider2D collider)
    {
        playerScore++;
        OnMissBall?.Invoke(playerScore);
        StartCoroutine(DisableOtherObject(collider));
    }

    IEnumerator DisableOtherObject(Collider2D other)
    {
        yield return new WaitForSeconds(disableTime);
        other.transform.position = Vector3.zero;
        other.gameObject.SetActive(false);
    }

    public void SetPosition(float horizontal) {
        Vector3 newPosition = transform.position;
        newPosition.x = side == Side.Left ? -horizontal : horizontal;
        transform.position = newPosition;
    }
}
