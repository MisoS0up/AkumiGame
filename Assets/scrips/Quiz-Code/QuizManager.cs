using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public static bool competent = false;
    

    public Text QuestionTxt;
    [SerializeField]public Image ImageHere;
    public Text scoreTxt;

    public GameObject QuizPanel;
    public GameObject GOPanel;
    public GameObject RetryButton;
    public GameObject Tip;

    public UnityEvent passed;
    


    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        generateQuestion();
        totalQuestions = QnA.Count;
    }

    public void correct()
    {
        score += 1;
        Debug.Log(score + " / " + QnA.Count);
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    void GameOver()
    {
        GOPanel.SetActive(true);
        QuizPanel.SetActive(false);
        scoreTxt.text = score + " / " + totalQuestions;

        if(score < totalQuestions)
        {
            RetryButton.SetActive(true);
            Tip.SetActive(true);
        }
        else if(score == totalQuestions)
        {
            competent = true;
            passed.Invoke();
        }
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void SetAnswers()
    {
        for (int i = 0; i< options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            
            if(QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Questions;
            ImageHere.sprite = QnA[currentQuestion].questions;

            SetAnswers();
        }
        else
        {
            GameOver();
            Debug.Log("Out of questions");
        }
        

    
       
    }
   

}
