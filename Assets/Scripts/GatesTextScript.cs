using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatesTextScript : MonoBehaviour
{
    Text text;
    public CountGates counter;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Minimum Active Gates: " + counter.minimumGates.ToString() + "\nCurrent Active Gates: " + counter.activeGates.ToString();
    }
}
