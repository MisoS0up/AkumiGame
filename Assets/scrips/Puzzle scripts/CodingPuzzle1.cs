using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class CodingPuzzle1 : MonoBehaviour
{

    public TextMeshProUGUI result_1, result_2;
    public TMP_InputField inputAns1, inputAns2, inputAns3;
    public UnityEvent check;
    public bool Approved = false;



    private void Update()
    {
        if (Approved)
        {
            check.Invoke();
        }
    }
    public void CheckAnswer()
    {
        result_1.text = "";
        result_2.text = "";


        if (inputAns1.text.Contains("System"))
        {
            if (inputAns2.text.Contains("out"))
            {
                if (inputAns3.text.Contains("println"))
                {
                    result_1.text = " You may Proceed ";
                    Approved = true;
                }
            }
        }
        else
        {
            result_2.text = " Wrong! You may try again. Remember Java Language is Case sensitive.";
            Approved = false;
        }

        inputAns1.text = "";
        inputAns2.text = "";
        inputAns3.text = "";
  
    }

    public void ResetPaper()
    {
        result_1.text = "";
        result_2.text = "";
    }
    public void Approvedd()
    {
        if(Approved = true)
        {
            Approved = true;
            Debug.Log("you may pass :)");
        }
        else
        {
            Approved = false;
        }
       
    }
}
    
