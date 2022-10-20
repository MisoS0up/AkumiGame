using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class elseIfChecker : MonoBehaviour
{
    public TextMeshProUGUI[] result;
    public TMP_InputField[] inputFields;
    public string[] answers;
    public UnityEvent CodeCheck;
    string[] wrongStatement = new string[] { "Wrong! You may try again. Remember Java Language is Case sensitive.", "Wrong! maybe check if you type the right code!", "Wrong! you can check the Forbidden Hint and comeback again to try!." };
    public bool CheckedCodes = false;


    private void Start()
    {
        result[0].text = " ";
        result[1].text = " ";
        CheckedCodes = false;
    }

    private void Update()
    {
        if (CheckedCodes == true)
        {
            CodeCheck.Invoke();
        }
    }
    public void CheckAnswer()
    {
        result[0].text = " ";
        result[1].text = " ";

        if (inputFields[0].text.Contains(answers[0]) && inputFields[1].text.Contains(answers[1]))
        {
            if (inputFields[2].text.Contains(answers[2])){
                Debug.Log("Correct");
                CheckedCodes = true;
                result[0].text = "You have fixed the plane!!!!";
            }
        }
        else
        {
            result[1].text = wrongStatement[Random.Range(0, wrongStatement.Length)];
            CheckedCodes = false;
            ResetPaper();
        }


    }

    public void ResetPaper()
    {
        result[0].text = " ";
        inputFields[0].text = " ";
        inputFields[1].text = " ";
        inputFields[2].text = " ";
    }



}
