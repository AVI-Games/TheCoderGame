using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTextScript : MonoBehaviour
{
    public Text text;
    public int resets;
    // Start is called before the first frame update
    void Start()
    {
        resets = PlayerPrefs.GetInt("resetsInLevel", 0);
        text = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Resets: " + resets.ToString();
    }
}
