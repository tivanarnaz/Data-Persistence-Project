using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    public InputField nameInput;
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score : " + GameManager.Instance.playerName + " : " + GameManager.Instance.bestScore;
    }

    public void StartNew()
    {
        if (!string.IsNullOrEmpty(nameInput.text))
        {
            GameManager.Instance.tempName = nameInput.text;
            SceneManager.LoadScene(1);
        }
    }

    public void Quit()
    {


#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
