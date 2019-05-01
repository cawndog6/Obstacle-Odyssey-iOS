using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RightHandler : MonoBehaviour, IPointerDownHandler
{
    private bool IsPressed; //keeps track if button is being pressed
    // Start is called before the first frame update
    void Start()
    {
        IsPressed = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        IsPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        IsPressed = false;
    }
    /* Returns true if button is pressed, false if it is not */
    public bool BeingPressed()
    {
        if (IsPressed == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}