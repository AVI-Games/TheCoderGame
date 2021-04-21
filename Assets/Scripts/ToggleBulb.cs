using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBulb : MonoBehaviour
{
    [SerializeField] private Sprite onSprite, offSprite;
    public bool isTurned;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        isTurned = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update(){
        if(isTurned){
            spriteRenderer.sprite = onSprite;
        } else {
            spriteRenderer.sprite = offSprite;
        }
    }
}
