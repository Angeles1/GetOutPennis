using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {


    public void NextScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }


    public void CloseGame()
    {
        Application.Quit();
    }
}
