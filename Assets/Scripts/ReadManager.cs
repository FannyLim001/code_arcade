using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.SceneManagement;

public class ReadManager : MonoBehaviour
{
    public TMP_Text unitTitle;
    public TMP_Text learnDesc;
    public GameObject textContentPlace;
    public TMP_Text textContent;
    // Start is called before the first frame update
    void Start()
    {
        MaterialData materialData = textContent.GetComponent<MaterialData>();

        int unit = PlayerPrefs.GetInt("LearnUnit");

        if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0])
        {
            unitTitle.text = materialData.materialTitle[unit];
            learnDesc.text = materialData.materialDesc[unit];
            textContent.text = materialData.materialPoint[unit];
        } else
        {
            unitTitle.text = materialData.materialTitleID[unit];
            learnDesc.text = materialData.materialDescID[unit];
            textContent.text = materialData.materialPointID[unit];
        }

        // Calculate preferred height
        float preferredHeight = textContent.preferredHeight;

        // Adjust the height of the RectTransform
        RectTransform rectTransform = textContent.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, preferredHeight);
    }

    public void PlayTest()
    {
        SceneManager.LoadScene("Test");
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
