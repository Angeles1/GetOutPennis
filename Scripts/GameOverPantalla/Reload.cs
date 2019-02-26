using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {

	public void reload()
    {
        SceneManager.UnloadSceneAsync("Game Over");
        SceneManager.LoadSceneAsync("SampleScene");
    }
}
