using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{

    public TimeScript timer;
    public CountGates gates;
    public ResetTextScript resets;


    public void ResetScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        PlayerPrefs.SetInt("timeInLevel", (timer.beggining_time+timer.time));
        resets.resets+=1;
        PlayerPrefs.SetInt("resetsInLevel", resets.resets);
    }
}
