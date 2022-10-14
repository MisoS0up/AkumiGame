using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is in Range");
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            
            isInRange = false;
            Debug.Log("Player is not in Range");
        
    }
}
