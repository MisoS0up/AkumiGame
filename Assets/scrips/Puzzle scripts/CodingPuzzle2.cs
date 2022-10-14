using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class CodingPuzzle2 : MonoBehaviour
{

    public TextMeshProUGUI result_1, result_2;
    public TMP_InputField inputAns1, inputAns2, inputAns3, inputAns4;
    public UnityEvent check;
    string[] wrongStatement = new string[] { "Wrong! You may try again. Remember Java Language is Case sensitive.", "Wrong! maybe check if you type the right code!", "Wrong! you can check the Forbidden Hint and comeback again to try!." };
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


        if (inputAns1.text.Contains("for"))
        {
            Debug.Log("answer: For correct ");
            if (inputAns2.text.Contains("spawn"))
            {
                Debug.Log("answer: spawn correct ");
                if (inputAns3.text.Contains("path"))
                {
                    Debug.Log("answer: path correct");
                    if (inputAns4.text.Contains("spawn"))
                    {
                        Debug.Log("answer: spawn correct");
                        result_1.text = " You may Proceed ";
                        Approved = true;
                    }
                }
            }
        }
        else
        {
            result_2.text = wrongStatement[Random.Range(0, wrongStatement.Length)];
            Approved = false;
        }

        inputAns1.text = "";
        inputAns2.text = "";
        inputAns3.text = "";
        inputAns4.text = "";

    }

    public void ResetPaper()
    {
        result_1.text = "";
        result_2.text = "";
    }
    public void Approvedd()
    {
        if (Approved = true)
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

