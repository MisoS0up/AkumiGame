using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class questChecker : MonoBehaviour
{
    public int quest = 0;
    public UnityEvent questCompleted;

   
    public void gearPart()
    {
        quest++;
        if(quest == 3)
        {
            Debug.Log("Quest Completed!!");
            questCompleted.Invoke();
        }
        Debug.Log("Gear Part Collected!= " + quest);

    }

    public void propellerPart()
    {
        quest++;
        if (quest == 3)
        {
            Debug.Log("Quest Completed!!");
            questCompleted.Invoke();
        }
        Debug.Log("Propeller Part Collected! = " + quest);
    }
    public void enginePart()
    {
        quest++;
        if (quest == 3)
        {
            Debug.Log("Quest Completed!!");
            questCompleted.Invoke();
        }
        Debug.Log("Engine Part Collected!! = " + quest);
    }

}
