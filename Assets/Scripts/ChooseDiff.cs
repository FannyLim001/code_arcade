using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseDiff : MonoBehaviour
{
    public void PlayEasy()
    {
        PlayerPrefs.SetInt("AlreadyPlay", 1);
        PlayerPrefs.SetInt("GameMode", 1);
        PlayerPrefs.SetInt("UnlockedSections", 1);
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayMediumOrHard()
    {
        SceneManager.LoadScene("Test");
    }
}
