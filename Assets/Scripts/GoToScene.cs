using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{

    public ConnectToDB dbConnect;

    public void ClickAndGo(string scene)
    {
        ChangeScene(scene);
    }

    public void ChangeAndUpdate(string scene)
    {
        dbConnect.Function();
        ChangeScene(scene);
    }

    private void ChangeScene(string scene){
        SceneManager.LoadScene(scene);
        PlayerPrefs.SetInt("timeInLevel", 0);
        PlayerPrefs.SetInt("resetsInLevel", 0);
        PlayerPrefs.SetInt("starsWon", 0);
    }

}

