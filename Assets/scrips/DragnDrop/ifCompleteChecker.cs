using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ifCompleteChecker : MonoBehaviour
{
    private int currentPoint;
    public UnityEvent Completed;
    public bool GameInspector = false;
    public void AddPoints()
    {
        currentPoint++;
        Debug.Log("PLUSSS 1");
        if (currentPoint >= 8)
        {
            Debug.Log("Completed Checking");
            GameInspector = true;
            Completed.Invoke();
        }

    }

}
