using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    Text text;
    public int time, beggining_time;

    void Start()
    {
        beggining_time = PlayerPrefs.GetInt("timeInLevel", 0);
        text = GetComponent<Text>();
        time = 0;
    }

    void Update()
    {
        text.text = "Tiempo Transcurrido: " + (Mathf.Floor(Time.timeSinceLevelLoad)+beggining_time).ToString() + " segundos.";
        time = (int)Mathf.Floor(Time.timeSinceLevelLoad);
        
    }
}
