using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneOpener : MonoBehaviour
{
    public Button myButton; // Assign your button GameObject in the Inspector

    void Start()
    {
        myButton.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
