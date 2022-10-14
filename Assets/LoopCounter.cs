using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoopCounter : MonoBehaviour
{
    public TextMeshProUGUI counter;


    public void LoopTextPlus()
    {
        for(int i = 1;i <= 5; i++)
        {
            counter.text = i + " / 5";
        }
    }
}
