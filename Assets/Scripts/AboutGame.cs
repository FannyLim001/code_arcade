using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutGame : MonoBehaviour
{
    public void BackToStart()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
