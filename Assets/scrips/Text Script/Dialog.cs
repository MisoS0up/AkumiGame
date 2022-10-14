using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;


public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public UnityEvent next;

    private void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    void Start()
    {
        Debug.Log("Index = "+index);
        Debug.Log("Sentence = " + sentences.Length);
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            Debug.Log("Index + 1 " + index);
        }
        else if (index == sentences.Length - 1)
        {
            continueButton.SetActive(false);
            next.Invoke();
        }

        else
        {
            textDisplay.text = "";
        }
    }


    public void NextStep()
    { 
        if(index == sentences.Length - 1)
        {
            continueButton.SetActive(false);
            next.Invoke();
        }
    }
}
