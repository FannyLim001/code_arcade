using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public bool isArrange = false;
    public string arrangedText = "";
    public QuizManager quizManager;
    public string[] arrangedArray;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.Correct();
        }
        else if (isArrange)
        {
            arrangedText += transform.GetChild(0).GetComponent<TMP_Text>().text + "\n";
            quizManager.QuestionText.text += arrangedText;

            arrangedArray = quizManager.StoreArrangement(arrangedText);

            bool arrangeCorrect = quizManager.CheckArrangement(arrangedArray);
            PlayerPrefs.SetInt("arrangeCorrect", arrangeCorrect ? 1 : 0);
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.Wrong();
        }
    }

    public void CheckArr()
    {
        bool arrangeCorrect = PlayerPrefs.GetInt("arrangeCorrect", 1) == 1;

        if (arrangeCorrect)
        {
            Debug.Log("All arrangements are correct, changing scene...");
            // Trigger scene change here
            quizManager.Correct();
        }
        else
        {
            Debug.Log("Arrangement is incorrect");
            // Handle incorrect arrangement (e.g., show message)
            quizManager.Wrong();
        }
    }
}


