using System;
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
    public GameObject textViewPort;
    public GameObject panel;
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

        // Adjust the height of the RectTransform of the viewport
        RectTransform viewportRectTransform = textViewPort.GetComponent<RectTransform>();
        float panelHeight = panel.GetComponent<RectTransform>().rect.height;
        float parentHeight = viewportRectTransform.parent.GetComponent<RectTransform>().rect.height;

        // Calculate the offset needed to align the bottom of the viewport with the bottom of the panel
        float bottomOffset = (parentHeight - panelHeight) + 50f;

        viewportRectTransform.offsetMin = new Vector2(viewportRectTransform.offsetMin.x, bottomOffset);

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
