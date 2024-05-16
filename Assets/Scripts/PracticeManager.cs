using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticeManager : MonoBehaviour
{
    public void PracticeTest()
    {
        PlayerPrefs.SetInt("LearnUnit", 99);
        SceneManager.LoadScene("Test");
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
