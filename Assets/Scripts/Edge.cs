using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class Edge : MonoBehaviour
{
    [SerializeField] float waitingTime;
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
        yield return new WaitForSeconds(waitingTime);
        other.transform.position = Vector3.zero;
        other.gameObject.SetActive(false);
    }
}
