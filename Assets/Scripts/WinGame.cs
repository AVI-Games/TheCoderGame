using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject winScreen, twoStar, oneStar, fail;
    public ToggleBulb bulb;
    public CountGates gates;

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

            Debug.Log(Mathf.Ceil((minimum/3)*2));
            if(gates.activeGates==(gates.minimumGates*1)){
                winScreen.SetActive(true);
            } else if (gates.activeGates>=(Mathf.Ceil((gates.minimumGates/3)*2))){
                twoStar.SetActive(true);
            } else if (gates.activeGates>=(Mathf.Ceil((gates.minimumGates/3)*1))){
                oneStar.SetActive(true);
            } else {
                fail.SetActive(true);
            }
        }
    }
}
