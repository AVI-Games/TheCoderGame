using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{

    public void ClickAndGo(string scene)
    {
        SceneManager.LoadScene(scene);
        PlayerPrefs.SetInt("timeInLevel", 0);
        PlayerPrefs.SetInt("resetsInLevel", 0);
    }
}
