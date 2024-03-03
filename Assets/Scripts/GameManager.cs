using UnityEngine;
using TMPro; // Import TMP_Text if you haven't already
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            sectionTitle.text = "Section " + (i + 1) + ": " + materialInfo.sectionTitle[i];

            Button buttonLearn = duplicatedMaterial.GetComponentInChildren<Button>();
            int sectionIndex = i; // Capture current index for the listener
            buttonLearn.onClick.AddListener(() => LearnMaterial(sectionIndex));

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
}
