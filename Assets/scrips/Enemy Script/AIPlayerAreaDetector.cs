using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayerAreaDetector : MonoBehaviour
{
    [field: SerializeField]
    public bool PlayerInArea { get; private set; }

    public Transform Player { get; private set; }

    [SerializeField]
    private string detectionTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(detectionTag)){
            PlayerInArea = true;
            Player = collision.gameObject.transform;
            Debug.Log("Player is in detected!");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(detectionTag))
        {
            PlayerInArea = false;
            Player = null;
            Debug.Log("Player is not detected!");
        }
    }

}
