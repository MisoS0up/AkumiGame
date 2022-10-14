using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectInteractable : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactAction;



    void Start()
    {

    }


    void Update()
    {
        if (isInRange)
        {
            interactAction.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Barrel"))
        {
            isInRange = true;
            Debug.Log("Barrel is placed!");
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        isInRange = false;
        Debug.Log("Barrel is not in Range");

    }
}
