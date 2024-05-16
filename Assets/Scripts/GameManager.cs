using UnityEngine;
using TMPro; // Import TMP_Text if you haven't already
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public GameObject materialPlace;
    public GameObject material;

    public TMP_Text diffTitle;

    void Start()
    {
        MaterialInfo materialInfo = material.GetComponent<MaterialInfo>();

        if (materialInfo == null)
        {
            Debug.LogError("MaterialInfo component not found on the material prefab.");
            return;
        }

        int numSections = materialInfo.sectionTitle.Length;

        for (int i = 0; i < numSections; i++)
        {
            GameObject duplicatedMaterial = Instantiate(material, materialPlace.transform);

            TMP_Text sectionTitle = duplicatedMaterial.GetComponentInChildren<TMP_Text>();

            Locale selectedLocale = LocalizationSettings.SelectedLocale;
            StringTable table = LocalizationSettings.StringDatabase.GetTable("Content");
            string translation = table.GetEntry("SectionKey").GetLocalizedString(selectedLocale);
            sectionTitle.text = translation + " " + (i + 1) + ": " + materialInfo.sectionTitle[i];

            Image sectionImage = null;
            Image checkImage = null;

            // Find images by their tags
            Image[] images = duplicatedMaterial.GetComponentsInChildren<Image>();
            foreach (Image image in images)
            {
                if (image.CompareTag("Section"))
                {
                    sectionImage = image;
                }
                else if (image.CompareTag("Finished"))
                {
                    checkImage = image;
                }
            }

            Button buttonLearn = duplicatedMaterial.GetComponentInChildren<Button>();

            // Check if both images were found
            if (sectionImage != null && checkImage != null)
            {
                // Modify sectionImage
                sectionImage.sprite = materialInfo.image[i];

                // Add listener to button
                int sectionIndex = i; // Capture current index for the listener
                buttonLearn.onClick.AddListener(() => LearnMaterial(sectionIndex));

                string sectionKey = "sectionCompleted_" + sectionIndex;
                // Modify checkImage alpha
                if (PlayerPrefs.GetInt(sectionKey) == 0)
                {
                    Color imageColor = checkImage.color;
                    imageColor.a = 0;
                    checkImage.color = imageColor;
                }
            }

            int gameMode = PlayerPrefs.GetInt("GameMode");
            if (gameMode == 3) // Hard Mode
            {
                diffTitle.text = "Hard Mode";
                if (i < PlayerPrefs.GetInt("UnlockedSections"))
                {
                    buttonLearn.interactable = true; // Unlocked
                }
                else
                {
                    buttonLearn.interactable = false; // Locked
                }
            }
            else if (gameMode == 2) // Medium Mode
            {
                diffTitle.text = "Medium Mode";
                if (i < PlayerPrefs.GetInt("UnlockedSections"))
                {
                    buttonLearn.interactable = true; // Unlocked
                }
                else
                {
                    buttonLearn.interactable = false; // Locked
                }
            }
            else if (gameMode == 1) // Easy Mode
            {
                diffTitle.text = "Easy Mode";
                if (i < PlayerPrefs.GetInt("UnlockedSections"))
                {
                    buttonLearn.interactable = true; // Unlocked
                }
                else
                {
                    buttonLearn.interactable = false; // Locked
                }
            }
        }
    }

    public void LearnMaterial(int unit)
    {
        Debug.Log("Clicked on section " + (unit + 1));
        PlayerPrefs.SetInt("LearnUnit",unit);
        SceneManager.LoadScene("ReadMaterial");
    }

    public void Practice()
    {
        SceneManager.LoadScene("Practice");
    }

    public void Back()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
