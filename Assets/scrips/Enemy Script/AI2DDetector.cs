using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AI2DDetector : MonoBehaviour
{
    [field: SerializeField]
    public bool PlayerInArea { get; private set; }
    public string targetTag = "Player";
    public UnityEvent OnTriggerEnterEvent, OntriggerExitEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            OnTriggerEnterEvent?.Invoke();
            Debug.Log("Player is detected!!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            OntriggerExitEvent?.Invoke();
            Debug.Log("Player is not detected!");
        }
    }
}
