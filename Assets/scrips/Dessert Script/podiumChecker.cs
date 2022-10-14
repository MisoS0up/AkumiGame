using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class podiumChecker : MonoBehaviour
{
    private ifCompleteChecker check;
    public UnityEvent BridgeOpen;

    private void Checked()
    {
        if (check.GameInspector == true)
        {
            Debug.Log("Bridge-Dialog-Invoke");
            BridgeOpen.Invoke();
        }
    }
}
