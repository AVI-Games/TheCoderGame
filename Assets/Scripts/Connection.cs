using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{
    public bool turnedOn;
    public ToggleAND and;
    public ToggleOR or;
    public ToggleBulb bulb;
    public ToggleNOT not;
    
    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("Leg1_AND")){
            and = trig.transform.parent.GetComponent<ToggleAND>();
            and.leg1 = turnedOn;
            Debug.Log(trig.name + "Touched Leg 1");
        } else if (trig.gameObject.CompareTag("Leg2_AND")){
            and = trig.transform.parent.GetComponent<ToggleAND>();
            and.leg2 = turnedOn;
            Debug.Log(trig.name + "Touched Leg 2");
        } else if (trig.gameObject.CompareTag("LightBulb")){
            bulb = trig.transform.parent.GetComponent<ToggleBulb>();
            bulb.isTurned = turnedOn;
            Debug.Log(trig.name + "Touched Light Bulb");
        } else if (trig.gameObject.CompareTag("Leg1_OR")){
            or = trig.transform.parent.GetComponent<ToggleOR>();
            or.leg1 = turnedOn;
        } else if (trig.gameObject.CompareTag("Leg2_OR")){
            or = trig.transform.parent.GetComponent<ToggleOR>();
            or.leg2 = turnedOn;
        } else if (trig.gameObject.CompareTag("Leg_NOT")){
            not = trig.transform.parent.GetComponent<ToggleNOT>();
            not.leg = turnedOn;
        }
    }

    void OnTriggerExit2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("Leg1_AND")){
            and = trig.transform.parent.GetComponent<ToggleAND>();
            and.leg1 = false;
            Debug.Log(trig.name + "Leg 1 turned off");
        } else if (trig.gameObject.CompareTag("Leg2_AND")){
            and = trig.transform.parent.GetComponent<ToggleAND>();
            and.leg2 = false;
            Debug.Log(trig.name + "Leg 2 turned off");
        } else if (trig.gameObject.CompareTag("LightBulb")){
            bulb = trig.transform.parent.GetComponent<ToggleBulb>();
            bulb.isTurned = false;
            Debug.Log(trig.name + "LightBulb turned off");
        }else if (trig.gameObject.CompareTag("Leg1_OR")){
            or = trig.transform.parent.GetComponent<ToggleOR>();
            or.leg1 = false;
        } else if (trig.gameObject.CompareTag("Leg2_OR")){
            or = trig.transform.parent.GetComponent<ToggleOR>();
            or.leg2 = false;
        } else if (trig.gameObject.CompareTag("Leg_NOT")){
            not = trig.transform.parent.GetComponent<ToggleNOT>();
            not.leg = false;
        }
    }
}
