using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    private void Start()
    {
        int localeID = PlayerPrefs.GetInt("LocaleKey");
        Debug.Log("locale ID: "+ localeID);
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];

        PlayerPrefs.SetInt("LocaleKey", localeID);
        PlayerPrefs.Save(); // Save PlayerPrefs immediately after changing the locale
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

    public void AboutGame()
    {
        SceneManager.LoadScene("AboutGame");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
