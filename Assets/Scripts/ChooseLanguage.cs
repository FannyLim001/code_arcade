using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLanguage : MonoBehaviour
{
    void Awake()
    {
        // Check if AlreadyPlay PlayerPrefs key exists
        if (!PlayerPrefs.HasKey("AlreadyPlay"))
        {
            // Set AlreadyPlay to 0 if it doesn't exist
            PlayerPrefs.SetInt("AlreadyPlay", 0);
        }

        // If player has already played, set the build index to the "StartMenu" scene
        if (PlayerPrefs.GetInt("AlreadyPlay") == 1)
        {
            SceneManager.LoadScene("StartMenu");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // If player is playing for the first time, log it
        if (PlayerPrefs.GetInt("AlreadyPlay") == 0)
        {
            Debug.Log("First Time Opening");
        }
    }

    // Method to be called when player wants to proceed to "StartMenu" scene
    public void GoToMain()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
