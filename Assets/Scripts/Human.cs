using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Human : MonoBehaviour
{
    // public string MainMenuScene;

    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Escape) && Application.platform == RuntimePlatform.Android)
    //     {
    //         SceneManager.LoadSceneAsync("MainMenuScene");
    //     }
    // }

    // void GoBack()
    // {
    //     if (!string.IsNullOrEmpty(MainMenuScene))
    //     {
    //         SceneManager.LoadSceneAsync(MainMenuScene);
    //     } else
    //     {
    //         Quit();
    //     }
    // }

    // void Quit()
    // {
    //     Application.Quit();
    // }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenuScene");
    }

    public void HumanBone()
    {
        SceneManager.LoadSceneAsync("HumanBoneScene");
    }
}
