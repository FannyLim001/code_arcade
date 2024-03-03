using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class QuizManager : MonoBehaviour
{
    public string currentUnit;
    public List<QuestionAnswer> Question;
    public List<QuestionAnswer> unansweredQuestion;
    public GameObject[] options;
    public int currentQuestion;
    public int questionCount;

    public TMP_Text QuestionNumber;
    public TMP_Text QuestionType;
    public TMP_Text QuestionText;

    private int correctAnswers = 0;
    private int totalQuestionsAnswered = 0;

    public float elapsedTime;

    public GameObject correctPanel;
    public GameObject incorrectPanel;
    public GameObject submitBtn;

    private void Start()
    {
        correctPanel.SetActive(false);
        incorrectPanel.SetActive(false);
        submitBtn.SetActive(false);
        InitializeQuestions();
        PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        PlayerPrefs.SetFloat("ResultTimer", elapsedTime);
    }

    public void Correct()
    {
        correctAnswers++;
        totalQuestionsAnswered++;
        unansweredQuestion.RemoveAt(currentQuestion);
        StartCoroutine(ShowCorrectPanel());
    }

    IEnumerator ShowCorrectPanel()
    {
        correctPanel.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        correctPanel.SetActive(false);
        GenerateQuestion();
    }

    public void Wrong()
    {
        totalQuestionsAnswered++;
        unansweredQuestion.RemoveAt(currentQuestion);
        StartCoroutine(ShowIncorrectPanel());
    }

    IEnumerator ShowIncorrectPanel()
    {
        incorrectPanel.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        incorrectPanel.SetActive(false);
        GenerateQuestion();
    }

    void SetAnswer()
    {
        if (unansweredQuestion[currentQuestion].IsMultipleChoice)
        {
            for (int i = 0; i < options.Length; i++)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].GetComponent<AnswerScript>().isArrange = false;
                options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = unansweredQuestion[currentQuestion].Answers[i];
                if (unansweredQuestion[currentQuestion].CorrectAnswer == i)
                {
                    options[i].GetComponent<AnswerScript>().isCorrect = true;
                }
            }

            submitBtn.SetActive(false);
        }
        else
        {
            for (int i = 0; i < options.Length; i++)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = false;
                options[i].GetComponent<AnswerScript>().isArrange = true;
                options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = unansweredQuestion[currentQuestion].Answers[i];
            }

            submitBtn.SetActive(true);
        }
    }

    public List<string> storedList = new List<string>();

    public string[] StoreArrangement(string userArrange)
    {
        storedList.Add(userArrange);
        string[] storedArr = storedList.ToArray();
        for (int i = 0; i < storedArr.Length; i++)
        {
            Debug.Log("array: " + storedArr[i]);
        }
        return storedArr;
    }

    public bool CheckArrangement(string[] userArrange)
    {
        bool correctArr = true;
        if (userArrange.Length != unansweredQuestion[currentQuestion].CorrectArrangement.Length)
        {
            Debug.LogError("Length of user's arrangement does not match the correct arrangement length.");
            correctArr = false;
        }
        else
        {
            for (int i = 0; i < userArrange.Length; i++)
            {
                if (userArrange[i].Trim() != unansweredQuestion[currentQuestion].CorrectArrangement[i])
                {
                    correctArr = false;
                }
            }
        }

        return correctArr;
    }

    void GenerateQuestion()
    {
        if (unansweredQuestion.Count > 0)
        {
            currentQuestion = Random.Range(0, unansweredQuestion.Count);
            var count = questionCount++;
            QuestionNumber.text = count.ToString();
            QuestionType.text = unansweredQuestion[currentQuestion].QuestionType;
            QuestionText.text = unansweredQuestion[currentQuestion].QuestionText;
            SetAnswer();
        }
        else
        {
            Debug.Log("Out of questions");
            float accuracyPercentage = CalculateAccuracyPercentage();
            Debug.Log("Accuracy Percentage: " + accuracyPercentage.ToString("0") + "%");
            PlayerPrefs.SetFloat("PlayerResult", accuracyPercentage);
            SceneManager.LoadScene("Result");
        }
    }

    float CalculateAccuracyPercentage()
    {
        if (totalQuestionsAnswered == 0)
            return 0f;
        return ((float)correctAnswers / totalQuestionsAnswered) * 100f;
    }

    void InitializeQuestions()
    {
        int unit = PlayerPrefs.GetInt("LearnUnit", -1);
        if (unit == -1)
        {
            currentUnit = "PreTest";
        }
        else if (unit >= 0)
        {
            int incrementUnit = unit + 1;
            currentUnit = "Unit " + incrementUnit.ToString();
        }

        if (QuizData.Questions.ContainsKey(currentUnit))
        {
            Question = QuizData.Questions[currentUnit];
            Debug.Log("Number of questions in the list: " + Question.Count);
            unansweredQuestion = new List<QuestionAnswer>(Question);
            GenerateQuestion();
        }
        else
        {
            Debug.LogError("Unit not found in the dictionary.");
        }
    }
}
