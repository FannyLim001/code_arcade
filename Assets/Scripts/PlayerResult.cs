using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayerResult : MonoBehaviour
{
    public TMP_Text accuracy;
    public TMP_Text timer;
    public Button continueBtn;
    public int totalSections = 6;

    void Start()
    {
        float accuracyValue = PlayerPrefs.GetFloat("PlayerResult");
        float timerValue = PlayerPrefs.GetFloat("ResultTimer");
        int minutes = Mathf.FloorToInt(timerValue / 60);
        int seconds = Mathf.FloorToInt(timerValue % 60);
        accuracy.text = accuracyValue.ToString("0") + "%";
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        int unit = PlayerPrefs.GetInt("LearnUnit", -1);

        if (unit < 0)
        {
            HandlePreTestResult(accuracyValue);
        }
        else
        {
            HandleTestResult(accuracyValue);
        }
    }

    void HandlePreTestResult(float accuracyValue)
    {
        if (accuracyValue == 100f)
        {
            PlayerPrefs.SetInt("AlreadyPlay", 1);
            PlayerPrefs.SetInt("GameMode", 3); // Hard mode
            PlayerPrefs.SetInt("UnlockedSections", 5);
        }
        else if (accuracyValue >= 50f)
        {
            PlayerPrefs.SetInt("AlreadyPlay", 1);
            PlayerPrefs.SetInt("GameMode", 2); // Medium mode
            PlayerPrefs.SetInt("UnlockedSections", 3);
        }
        else
        {
            Debug.Log("Pretest failed. Please retry."); // Pretest failed
            continueBtn.interactable = false;
        }
    }

    void HandleTestResult(float accuracyValue)
    {
        if (accuracyValue >= 50f)
        {
            Debug.Log("Pass");
            LevelFinished(PlayerPrefs.GetInt("LearnUnit"));
        }
        else
        {
            Debug.Log("Failed"); // Failed test
        }
    }

    void LevelFinished(int sectionIndex)
    {
        string sectionKey = "sectionCompleted_" + sectionIndex;

        if (PlayerPrefs.GetInt(sectionKey) == 0)
        {
            PlayerPrefs.SetInt("UnlockedSections", PlayerPrefs.GetInt("UnlockedSections") + 1);
            PlayerPrefs.SetInt(sectionKey, 1);

            if(PlayerPrefs.GetInt("UnlockedSections") == 3)
            {
                PlayerPrefs.SetInt("GameMode",2);
            } else if (PlayerPrefs.GetInt("UnlockedSections") == 5)
            {
                PlayerPrefs.SetInt("GameMode", 3);
            }
        }
        else
        {
            Debug.Log("Section " + sectionIndex + " is already completed");
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("Test");
    }

    public void Continue()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
