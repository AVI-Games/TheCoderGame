using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAND : MonoBehaviour
{
    public GameObject andStart, andEnd, andConnection;
    [SerializeField] private Sprite onSprite, offSprite;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Connection connection;
    public bool isTrue;
    public bool leg1, leg2;
    public CountGates counter;
    private bool functionCalled;

    // Start is called before the first frame update
    void Start()
    {
        this.isTrue = false;
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        andStart.SetActive(false);
        andEnd.SetActive(false);
        andConnection.SetActive(false);
        // connection = GetComponent<Connection>();
    }

    // Update is called once per frame
    void Update()
    {
        if(leg1 && leg2){
            this.isTrue = true;
            connection.turnedOn = true;
            andStart.SetActive(true);
            andEnd.SetActive(true);
            andConnection.SetActive(true);
            checkTrue();
        } else {
            this.isTrue = false;
            connection.turnedOn = false;
            andStart.SetActive(false);
            andEnd.SetActive(false);
            andConnection.SetActive(false);
            checkFalse();
        }
        checkSprite();
    }

    void checkSprite(){
        if(isTrue){
            this.spriteRenderer.sprite = onSprite;
        } else {
            this.spriteRenderer.sprite = offSprite;
        }        
    }

    void checkTrue(){
        if(!functionCalled){
            functionCalled = true;
            counter.activeGates += 1;
        }
    }
    void checkFalse(){
        if(functionCalled){
            functionCalled = false;
            counter.activeGates -= 1;
        }
    }
}
