using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneBySceneChecker : MonoBehaviour
{
    public UnityEvent passed;
    public bool Passed = false;
    void Start()
    {
        if(GameControl.MatchedCounter == 4)
        {
            Passed = true;
            if(Passed = true)
            {
                passed.Invoke();
            }
        }

    }
    void Update()
    {
        
    }
}
