using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    
    public bool selected {get; private set;}

    // Update is called once per frame
    void Update()
    {

        if(selected){
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
            selected = true;
        }
        
        if(Input.GetMouseButtonUp(0)){
            selected = false;
        }
    }
}
