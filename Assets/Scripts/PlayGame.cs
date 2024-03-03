using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    void Awake()
    {
        // Check if AlreadyPlay PlayerPrefs key exists
        if (!PlayerPrefs.HasKey("AlreadyPlay"))
        {
            // Set AlreadyPlay to 0 if it doesn't exist
            PlayerPrefs.SetInt("AlreadyPlay", 0);
        }
    }

    public void StartBtn()
    {
        if (PlayerPrefs.GetInt("AlreadyPlay") == 1)
        {
            Debug.Log("NOT First Time Opening");
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            Debug.Log("First Time Opening");
            SceneManager.LoadScene("ChooseDifficulty");
        }
    }
}
