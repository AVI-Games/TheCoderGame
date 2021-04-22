using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwitch : MonoBehaviour
{
    public GameObject switchStart, switchEnd, switchConnection;
    public Sprite offSprite;
    public Sprite onSprite;
    private bool isTurned;
    private SpriteRenderer spriteRenderer;
    public Connection connection;

    // Start is called before the first frame update
    void Start()
    {
        isTurned = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
        switchStart.SetActive(false);
        switchEnd.SetActive(false);
        switchConnection.SetActive(false);
        // connection = gameObject.GetComponent<Connection>();
    }

    /*
        When you click on the light switch, it's gonna either turn on or off, 
        depending on the previous state, and it's gonna change the sprite to
        show the change.
    */
    void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0)){
            if(isTurned){
                isTurned = false;
                Debug.Log(isTurned);
                connection.turnedOn = false;
                spriteRenderer.sprite = offSprite;
                switchStart.SetActive(false);
                switchEnd.SetActive(false);
                switchConnection.SetActive(false);
            } else {
                isTurned = true;
                Debug.Log(isTurned);
                connection.turnedOn = true;
                spriteRenderer.sprite = onSprite;
                switchStart.SetActive(true);
                switchEnd.SetActive(true);
                switchConnection.SetActive(true);
            }
        }
    }

}
