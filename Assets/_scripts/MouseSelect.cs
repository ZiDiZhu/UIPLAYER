using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseSelect : MonoBehaviour
{
    public TMP_Text selectedText;
    public TMP_Text typeText;
    public TMP_Text coordText;
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Outline>().enabled = true;
        selectedText.text = "Selected: " + gameObject.name;
        typeText.text = "Type: " + gameObject.tag;
        coordText.text = "Coordinate: " + transform.localPosition.x + ", " + transform.localPosition.y + ", " + transform.localPosition.z + ", ";

        if (Input.GetMouseButtonDown(0))
        {
            //select
            
        }
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
        selectedText.text = "Selected: None";
        typeText.text = "Type: ";
        coordText.text = "Coordinate: ";
    }


}
