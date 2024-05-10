using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocaleSelector : MonoBehaviour
{
    private static LocaleSelector instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Ensure this GameObject persists across scene changes
            int savedLocaleID = PlayerPrefs.GetInt("LocaleKey", 0);
            ChangeLocale(savedLocaleID);
        }
        else
        {
            Destroy(gameObject); // If another instance exists, destroy this one
            return;
        }
    }

    public void ChangeLocale(int localeID)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];

        PlayerPrefs.SetInt("LocaleKey", localeID);
        PlayerPrefs.Save(); // Save PlayerPrefs immediately after changing the locale
    }
}
