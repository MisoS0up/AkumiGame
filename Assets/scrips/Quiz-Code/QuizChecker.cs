using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class QuizChecker : MonoBehaviour
{
    public UnityEvent competent;
    public bool compe = false;

    private void Start()
    {
        if (QuizManager.competent == true)
        {
            compe = true;
            if(compe = true)
            {
                competent.Invoke();
            }
        }
    }


}
