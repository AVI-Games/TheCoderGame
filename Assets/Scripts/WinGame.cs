using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject winScreen, twoStar, oneStar, fail;
    public ToggleBulb bulb;
    public CountGates gates;
    public int stars;

    // Start is called before the first frame update
    void Start()
    {
        gates=GetComponent<CountGates>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bulb.isTurned){
            float minimum = gates.minimumGates;

            if(gates.activeGates>=(gates.minimumGates*1)){
                winScreen.SetActive(true);
                stars = 3;
            } else if (gates.activeGates>=(Mathf.Ceil((gates.minimumGates/3)*2))){
                twoStar.SetActive(true);
                stars = 2;
            } else if (gates.activeGates>=(Mathf.Ceil((gates.minimumGates/3)*1))){
                oneStar.SetActive(true);
                stars = 1;
            } else {
                fail.SetActive(true);
                stars = 0;
            }

            PlayerPrefs.SetInt("starsWon", stars);
        }
    }
}
