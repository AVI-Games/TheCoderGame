using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{

    public TimeScript timer;
    public CountGates gates;
    public int resets;

    // Start is called before the first frame update
    void Start()
    {
        resets = PlayerPrefs.GetInt("resetsInLevel", 0);
    }

    public void ResetScene(string scene)
    {
        // Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene);
        PlayerPrefs.SetInt("timeInLevel", (timer.beggining_time+timer.time));
        resets+=1;
        PlayerPrefs.SetInt("resetsInLevel", resets);
    }
}
