using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void SaveUserName()
    {
        PlayerPrefs.SetString("UserName", nameInputField.text);
        //SceneManager.LoadScene("MainScene"); // Load the main scene
    }


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        if (true)
        {
            UnityEditor.EditorApplication.ExitPlaymode();
        }
        else
#endif
        {
            Application.Quit();
        }
    }

}
