using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public bool isArrange = false;
    public string arrangedText = "";
    public QuizManager quizManager;
    public string[] arrangedArray;

    private bool added = false;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        quizManager = FindObjectOfType<QuizManager>();
    }

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.Correct();
        }
        else if (isArrange)
        {
            Debug.Log("Arranged Question");

            string newText = transform.GetChild(0).GetComponent<TMP_Text>().text;

            if (!added)
            {
                // Add the value to the array and update UI
                arrangedText = newText;
                quizManager.QuestionText.text += arrangedText + "\n";
                arrangedArray = quizManager.StoreArrangement(arrangedText);
                added = true;
                image.color = Color.gray; // Set the button color to gray
            }
            else
            {
                ResetArrangement();
            }

            for (int i = 0; i < arrangedArray.Length; i++)
            {
                Debug.Log("Array " + i + " : " + arrangedArray[i]);
            }

            // Check arrangement correctness
            bool arrangeCorrect = quizManager.CheckArrangement(arrangedArray);
            PlayerPrefs.SetInt("arrangeCorrect", arrangeCorrect ? 1 : 0);
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.Wrong();
        }
    }

    private void ResetArrangement()
    {
        quizManager.QuestionText.text = "";
        arrangedText = "";
        for (int i = 0; i < arrangedArray.Length; i++)
        {
            arrangedArray[i] = null; // Or arrangedArray[i] = "";
        }
        quizManager.ResetStoredList(); // Reset stored list for arrangement
        added = false;
        image.color = Color.white; // Reset button color to white
    }

    public void CheckArr()
    {
        bool arrangeCorrect = PlayerPrefs.GetInt("arrangeCorrect", 0) == 1;

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

    public void ResetVariables()
    {
        arrangedText = "";
        arrangedArray = null;
        quizManager.ResetStoredList();
        added = false;
        PlayerPrefs.SetInt("arrangeCorrect", 0); // Reset arrangement correctness status
    }
}
